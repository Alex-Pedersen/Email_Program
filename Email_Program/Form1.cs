﻿using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Email_Program.Properties;

namespace Email_Program
{
    public partial class
        Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            emailBox.Text = ConfigurationManager.AppSettings["email"];
            emailPassWordBox.Text = ConfigurationManager.AppSettings["password"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                emailAttachmentBox.Text = openFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient("smtp.gmail.com", 587); //Works if you have a gmail
                var message = new MailMessage(); //Creating a new instance of the email class
                message.From = new MailAddress(emailBox.Text); //Puts your email ID into message
                message.To.Add(emailReceiverBox.Text); //Puts receiver's email into message
                message.Body = emailBodyBox.Text; //Puts the body of the email into the message
                message.Subject = emailSubjectBox.Text; //Puts the subject into the 

                client.UseDefaultCredentials = false; //Overrides default credentials
                client.EnableSsl = true; //Enables ssl security

                if (emailAttachmentBox.Text != string.Empty) //Checking whether or not there's an attachment
                {
                    message.Attachments.Add(new Attachment(emailAttachmentBox.Text));
                }

                client.Credentials = new NetworkCredential(emailBox.Text, emailPassWordBox.Text);
                    //Creates a credentials object
                client.Send(message); //Sends the message

                MessageBox.Show(Resources.Form1_button2_Click_Message_has_been_sent_from__ + Environment.NewLine +
                                emailBox.Text + Environment.NewLine +
                                Resources.Form1_button2_Click_Message_has_been_sent_to__ + Environment.NewLine +
                                emailReceiverBox.Text);

                setTextBoxNull(new[]
                {
                    emailReceiverBox,
                    emailAttachmentBox,
                    emailSubjectBox,
                    emailBodyBox
                });
            }
            catch (Exception s)
            {
                MessageBox.Show(Resources.Form1_button2_Click_Failed_to_send_the_message_ + s.StackTrace);
                //Catches the exceptions and shows an error dialog box.
            }
        }

        private void setTextBoxNull(TextBox[] args)
        {
            foreach (var variable in args)
            {
                variable.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setTextBoxNull(new[]
            {
                emailBox,
                emailReceiverBox,
                emailAttachmentBox,
                emailSubjectBox,
                emailPassWordBox,
                emailBodyBox
            });
        }
    }
}