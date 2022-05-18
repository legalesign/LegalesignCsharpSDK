using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using System.IO;
using Newtonsoft.Json;

namespace LegalesignTest
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// The simplest examples with minimal error handling to keep the examples
        /// as clear as possible.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private Configuration makeConfig() {
            Configuration c = new Configuration();
            c.AddApiKey("Authorization", $"ApiKey {txtUsername.Text}:{txtSecretKey.Text}");
            
            return c;
        }
        private void btnCall_Click(object sender, EventArgs e)
        {           
            GroupApi group = new GroupApi(makeConfig());
            GroupListResponse groupList = group.GetGroups();
            
            richTextBox1.Text = groupList.ToJson();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupApi group = new GroupApi(makeConfig());
            
            GroupResponse response = group.GetGroup(txtGroupName.Text);

            richTextBox1.Text = response.ToJson();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DocumentApi docs = new DocumentApi(makeConfig());
            DocumentListResponse documentList = docs.GetDocuments();

            richTextBox1.Text = documentList.ToJson();
        }

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
    }
}
