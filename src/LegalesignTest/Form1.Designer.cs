
namespace LegalesignTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCall = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnGroupDetails = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnGetDocuments = new System.Windows.Forms.Button();
            this.rtbBodyHTML = new System.Windows.Forms.RichTextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUploadPdf = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(3, 61);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(163, 23);
            this.btnCall.TabIndex = 0;
            this.btnCall.Text = "Get Groups";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(521, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(368, 497);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnGroupDetails
            // 
            this.btnGroupDetails.Location = new System.Drawing.Point(3, 32);
            this.btnGroupDetails.Name = "btnGroupDetails";
            this.btnGroupDetails.Size = new System.Drawing.Size(163, 23);
            this.btnGroupDetails.TabIndex = 2;
            this.btnGroupDetails.Text = "Group Details";
            this.btnGroupDetails.UseVisualStyleBackColor = true;
            this.btnGroupDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGroupName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSecretKey);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(87, 97);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(168, 20);
            this.txtGroupName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Group Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Secret Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(87, 68);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(168, 20);
            this.txtSecretKey.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(87, 36);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(168, 20);
            this.txtUsername.TabIndex = 0;
            // 
            // btnGetDocuments
            // 
            this.btnGetDocuments.Location = new System.Drawing.Point(3, 3);
            this.btnGetDocuments.Name = "btnGetDocuments";
            this.btnGetDocuments.Size = new System.Drawing.Size(163, 23);
            this.btnGetDocuments.TabIndex = 5;
            this.btnGetDocuments.Text = "Get Documents";
            this.btnGetDocuments.UseVisualStyleBackColor = true;
            this.btnGetDocuments.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtbBodyHTML
            // 
            this.rtbBodyHTML.Location = new System.Drawing.Point(279, 12);
            this.rtbBodyHTML.Name = "rtbBodyHTML";
            this.rtbBodyHTML.Size = new System.Drawing.Size(236, 497);
            this.rtbBodyHTML.TabIndex = 6;
            this.rtbBodyHTML.Text = resources.GetString("rtbBodyHTML.Text");
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(3, 90);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(163, 23);
            this.btnPost.TabIndex = 7;
            this.btnPost.Text = "Post Document";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnGetDocuments);
            this.flowLayoutPanel1.Controls.Add(this.btnGroupDetails);
            this.flowLayoutPanel1.Controls.Add(this.btnCall);
            this.flowLayoutPanel1.Controls.Add(this.btnPost);
            this.flowLayoutPanel1.Controls.Add(this.btnUploadPdf);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(219, 195);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flowLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 335);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Calls";
            // 
            // btnUploadPdf
            // 
            this.btnUploadPdf.Location = new System.Drawing.Point(3, 119);
            this.btnUploadPdf.Name = "btnUploadPdf";
            this.btnUploadPdf.Size = new System.Drawing.Size(163, 23);
            this.btnUploadPdf.TabIndex = 8;
            this.btnUploadPdf.Text = "Upload PDF";
            this.btnUploadPdf.UseVisualStyleBackColor = true;
            this.btnUploadPdf.Click += new System.EventHandler(this.btnUploadPdf_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.rtbBodyHTML);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Example C# Calls";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnGroupDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetDocuments;
        private System.Windows.Forms.RichTextBox rtbBodyHTML;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUploadPdf;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

