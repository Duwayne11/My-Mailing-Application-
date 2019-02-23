using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {

                MailMessage message = new MailMessage();                    //  Initialize a new instance of the mailMessage class        
                message.From = new MailAddress(myEmailAddress.Text);        //Email address from 
                foreach (string toRecipiant in recipiant.Text.Split(';'))   //Recipiant email address (using the To Add method in the MailMessage class)
                    message.To.Add(toRecipiant);
                message.Subject = subject.Text;                             // email subject (using the subject method in the MailMessage class)
                message.Body = body.Text;                                   //message body (using the body method in the )

                message.Attachments.Add(new Attachment(attachement.Text));  //initializing a new instance of the attachement classs

                //server details

                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential(myEmailAddress.Text, myPassword.Text);
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
            }     
            catch
            {
                MessageBox.Show("An error occured, please see that all the fields are completed correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
            }



        }

        private void btnAttachement_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();                      //the openFileDialog will open the dialog allowing you to select a file
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            { 
               string filePath = ofd.FileName.ToString();                   

                attachement.Text = filePath;                                //the file path will be displayed, but I will make the textbox hidden 

            }



        }
    }
}
