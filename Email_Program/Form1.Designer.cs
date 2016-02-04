namespace Email_Program
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailReceiverBox = new System.Windows.Forms.TextBox();
            this.emailAttachmentBox = new System.Windows.Forms.TextBox();
            this.emailSubjectBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailPassWordBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.emailBodyBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your email ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Receiver\'s Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add attachment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Body";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(108, 12);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(201, 20);
            this.emailBox.TabIndex = 0;
            // 
            // emailReceiverBox
            // 
            this.emailReceiverBox.Location = new System.Drawing.Point(108, 43);
            this.emailReceiverBox.Name = "emailReceiverBox";
            this.emailReceiverBox.Size = new System.Drawing.Size(476, 20);
            this.emailReceiverBox.TabIndex = 2;
            // 
            // emailAttachmentBox
            // 
            this.emailAttachmentBox.Location = new System.Drawing.Point(108, 76);
            this.emailAttachmentBox.Name = "emailAttachmentBox";
            this.emailAttachmentBox.ReadOnly = true;
            this.emailAttachmentBox.Size = new System.Drawing.Size(368, 20);
            this.emailAttachmentBox.TabIndex = 1;
            this.emailAttachmentBox.TabStop = false;
            // 
            // emailSubjectBox
            // 
            this.emailSubjectBox.Location = new System.Drawing.Point(108, 106);
            this.emailSubjectBox.Name = "emailSubjectBox";
            this.emailSubjectBox.Size = new System.Drawing.Size(476, 20);
            this.emailSubjectBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // emailPassWordBox
            // 
            this.emailPassWordBox.Location = new System.Drawing.Point(385, 12);
            this.emailPassWordBox.Name = "emailPassWordBox";
            this.emailPassWordBox.Size = new System.Drawing.Size(201, 20);
            this.emailPassWordBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add attachment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // emailBodyBox
            // 
            this.emailBodyBox.Location = new System.Drawing.Point(108, 140);
            this.emailBodyBox.Multiline = true;
            this.emailBodyBox.Name = "emailBodyBox";
            this.emailBodyBox.Size = new System.Drawing.Size(476, 159);
            this.emailBodyBox.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 348);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.emailBodyBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailPassWordBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailSubjectBox);
            this.Controls.Add(this.emailAttachmentBox);
            this.Controls.Add(this.emailReceiverBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Email Forwarder V0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox emailReceiverBox;
        private System.Windows.Forms.TextBox emailAttachmentBox;
        private System.Windows.Forms.TextBox emailSubjectBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailPassWordBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox emailBodyBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
    }
}

