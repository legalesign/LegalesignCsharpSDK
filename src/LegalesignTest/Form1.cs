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

namespace LegalesignTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Configuration makeConfig() {
            Configuration c = new Configuration();
            //c.BasePath = "https://lon-dev.legalesign.com/api/v1";
            c.AddApiKey("Authorization", "ApiKey " + txtUsername.Text + ":" + txtSecretKey.Text);
            
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
            signers.Add(new DocumentSignerPost(email: "alex.weinle@legalesign.com", firstname: "Alex", lastname:"Weinle"));

            //You must provide group id as lowercase
            DocumentPost dp = new DocumentPost(
                group: $"/api/v1/group/{txtGroupName.Text.ToLower()}/",
                name: "dotnetdocument",
                text: "<h1>C Sharp Agreement</h1><p>terms as follows:: <span class=\"field\" data-optional=\"false\" data-name=\"Please add your ...\" data-idx=\"0\" data-signee=\"1\" data-type=\"signature\" data-options=\"\"> ....... </span></p>",
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
    }
}
