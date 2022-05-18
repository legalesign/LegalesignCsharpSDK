# API quickstart with the C# SDK
Our C# SDK can be generated using the OpenAPI3 specification of our API and openapi generator. However
we recommend you use the generated project provided, as it includes fixes to
some issues with the generator such as nullable fields.

The package contains its own documentation (in docs/), but the examples below will show you how to get started.

## Get your API Key
Sign up for a trial account. Configure for API when prompted, and email support to get an API Key. You need to show a level of understanding about using REST API, include a brief summary of your programming/REST experience.

Once issued, your API key will be available in the web app. You will see you are in sandbox - add any emails where you will send your test documents.

Your api key goes in the "Authorization" header, and takes the form: Apikey username:secret. Your username and secret will be clearly indicated in the web app.

## Get the SDK and Example projects

With you git tools of choice clone the C# SDK repository.

'''
git clone https://github.com/legalesign/LegalesignCsharpSDK.git legalesignSDK
'''

### Configure the Example project

Open the LegalesignCsharpSDK.sln and build the project. You should
see three projects included in the solution, we'll focus on 
the LegalesignTest which will get you started making calls to the REST api.

To save time you may want to add your username, secret, group name, target email,
first name and last name as 
the Text properties for txtUsername, txtSecretKey etc in 
Form1. If not you'll need to supply these when you run the Winform
project (ensure this is marked as the startup project). If you do hard code them
remember to remove that information once you're finished with the project.

Let's looks at the first code block in Form1.cs:


```
private Configuration makeConfig() {
    Configuration c = new Configuration();
    c.AddApiKey("Authorization", $"ApiKey {txtUsername.Text}:{txtSecretKey.Text}");
            
    return c;
}
```

You can see how this is using the username and secret that you supply and
passing it into the configuration for every call we'll be making later. This
is how API calls are authorized.

### Test a GET request

Let's make sure you can make a plain GET request, to check your Auth is configured properly.

The following code runs when you click the `Get Groups` button. Take some time
to notice where the Configuration information is passed in using `makeConfig()`.
Run the project, enter you username and key in the boxes if you haven't coded them
into the Text property and click the `Get Groups` button.

```
private void btnCall_Click(object sender, EventArgs e)
{           
    GroupApi group = new GroupApi(makeConfig());
    GroupListResponse groupList = group.GetGroups();
            
    richTextBox1.Text = groupList.ToJson();
}
```

If successful you'll get a JSON list of your groups. 
If not double check you have your Authorization value correct.

This code gets any documents waiting to be signed, a common use-case. Test
it by examining then running the `Get Documents` button.

```
private void button2_Click(object sender, EventArgs e)
{
    DocumentApi docs = new DocumentApi(makeConfig());
    DocumentListResponse documentList = docs.GetDocuments();

    richTextBox1.Text = documentList.ToJson();
}
```

> The 'get_statuses()' and 'get_status()' calls are a faster ways to query for basic doc information.

You should be starting to understand how SDK works. Go back to the package Readme file, and you will see all the API objects to try, and all their methods.

## Test a POST request
Next we will send some custom HTML for signing in one API call,
then we'll upload a PDF and send that.

### Send an HTML document to get signed

Here's a small amount of HTML for demo purposes, containing one signature element. Replace the group, name and email values.

```
private void btnPost_Click(object sender, EventArgs e)
{
    DocumentApi docs = new DocumentApi(makeConfig());

    List<DocumentSignerPost> signers = new List<DocumentSignerPost>();
    signers.Add(new DocumentSignerPost(email: txtEmail.Text, firstname: txtFirstname.Text, lastname: txtLastname.Text));

    //You must provide group id as lowercase
    DocumentPost dp = new DocumentPost(
        group: $"/api/v1/group/{txtGroupName.Text.ToLower()}/",
        name: "dotnetdocument",
        text: rtbBodyHTML.Text,
        signers: signers,
        doEmail: true,
        footerHeight:30,
        footer: "Legalesign ID: {{doc_id}}");

    try
    {
        InlineResponse201 resp = docs.PostDocument(dp);
        richTextBox1.Text = resp.ToJson();
    }
    catch (Exception ex) {
        throw ex;
    }
}
```

How do we know it went through? OpenAPI throws an exception for non 2XX responses. 
You will want to put all your requests into a try/catch block.

Every time you POST, you will probably want the new object ID. It's in the Location header of the response. In
our next example we see how to upload a PDF for us to send to signers, and get the ID back for that new template.


### Upload and send a PDF

You will most likely use text-tags within your PDFs, to define where people will sign or fill out any forms.

Lets upload a PDF using the 'with_http_info' version of the POST request to get the ID:

```
private void btnUploadPdf_Click(object sender, EventArgs e)
{
    DialogResult result = openFileDialog1.ShowDialog();

    if (result == System.Windows.Forms.DialogResult.OK)
    {
        TemplatepdfApi pdf = new TemplatepdfApi(makeConfig());

        // Get the file and convert the contents to a base64 byte array.
        Byte[] bytes = File.ReadAllBytes(openFileDialog1.FileName);
        String contents = Convert.ToBase64String(bytes);
        Byte[] encodedBytes = Convert.FromBase64String(contents);

        try
        {
            // Upload the pdf for our group to use with a title and a tag
            ApiResponse<object> response = pdf.PostPdfTemplateWithHttpInfo(new TemplatePdfFieldPost(group: $"/api/v1/group/{txtGroupName.Text.ToLower()}/",
                pdfFile: encodedBytes, processTags: true, title: "test tagged document"));

            // Just to demonstrate how to read response headers we'll put the returned
            // header in the output rich text box. The 'Location' header contains the new
            // Template ID.
            richTextBox1.Text = JsonConvert.SerializeObject(response.Headers);
                    
            // We'll save this so we can use it when calling Send with Template
            txtPDFLocation.Text = response.Headers["Location"];

        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}
```

Because we set process_tags to true, all the tags have been processed so your PDF is ready to go.
As before, we need the ID for the PDF so we can send it. Luckily we kept it in the
`txtPdfLocation` text box.

The last code snippet from `Send with Template` shows how we use that PDF location to send
a pre-loaded document to be signed.

```
private void btnSendTemplate_Click(object sender, EventArgs e)
{
    DocumentApi docs = new DocumentApi(makeConfig());

    List<DocumentSignerPost> signers = new List<DocumentSignerPost>();
    signers.Add(new DocumentSignerPost(email: txtEmail.Text, firstname: txtFirstname.Text, lastname: txtLastname.Text));

    //You must provide group id as lowercase
    DocumentPost dp = new DocumentPost(
        group: $"/api/v1/group/{txtGroupName.Text.ToLower()}/",
        name: "dotnetdocument",
        template: txtPDFLocation.Text,
        signers: signers,
        doEmail: true,
        footerHeight: 30,
        footer: "Legalesign ID: {{doc_id}}");

    try
    {
        InlineResponse201 resp = docs.PostDocument(dp);
        richTextBox1.Text = resp.ToJson();
    }
    catch (Exception ex)
    {
        throw ex;
    }
}
```


## Get coding

Be sure to check the OpenAPI generated documentation for different call types and options. 

Some common gotchas are:

The group name must exactly match one you already have in your organisation.

Your request will be denied if you credentials are incorrect, out of date or locked.

401 will come back if you are in sandbox and try and send a document to someone not in your sandbox email list.

*Happy coding!*