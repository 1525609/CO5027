using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        //credential - for username and password:
        SmtpClient smtpClient = new SmtpClient();

        //settings specific to the mail service:
        smtpClient.Host = "smtp.gmail.com";
        smtpClient.Port = 587;
        smtpClient.EnableSsl = true;


        System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("dungeon.co@gmail.com", "p@ssw0rd123");
        smtpClient.Credentials = credentials;
        MailMessage msg = new MailMessage("dungeon.co@gmail.com", txtEmail.Text);
        msg.Subject = "Name: " + txtName.Text + " Subject:" + txtSubject.Text;
        msg.Body = txtEmail.Text + " " + txtMsg.Text;


        try
        {
            smtpClient.Send(msg);
            lblLiteral.Text = "<p>Success, mail sent using SMTP with secure connection and credentials. </p>";
        }
        catch (Exception ex)
        {
            //display the full error to the user
            lblLiteral.Text = "<p> Sendfailed: " + ex.Message + ":" + ex.InnerException + "</p>";
        }
    }
}
