using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StaycationMate.Services
{
    public class EmailSender
    {
        // *Attribution: This EmailSender code snippet is customised based on the material provided by the FIT5032 teaching team

        // Yandex
        private const String API_KEY = "USE YOUR SendGrid API KEY";


        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("USE YOUR CONFIGURED SENDER EMAIL", "Staycation Mate - DO NOT REPLY THIS EMAIL");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }





        // Create a new method for sending bulk emails, taking 3 parameters; allUserEmails as a List, subjects as a String, and contents as a String
        public void SendBulk(List<String> allUserEmails, String subjects, String contents, string postedFile)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("USE YOUR CONFIGURED SENDER EMAIL", "Staycation Mate - Newsletter");


            // To add all users' email account, use this Personalization() class from SendGrid
            var personalisation = new Personalization();

            // You MUST initialise this .Tos as a List of EmailAddress, otherwise null Object exception will be thrown
            personalisation.Tos = new List<EmailAddress>();

            // Loop over all emails that are passed from the method caller, add this each emaill as a EmailAddress type (with actual email string, and receiver name string)
            foreach (var email in allUserEmails)
            {
                personalisation.Tos.Add(new EmailAddress(email, ""));
            }

            // Set this personalised email list as the receiver
            var tos = personalisation.Tos;

            var subject = subjects;
            var plainTextContent = contents;
            var htmlContent = "<h3>" + contents + "</h3>";
            var showAllRecipients = false;
            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, tos, subject, plainTextContent, htmlContent, showAllRecipients);
            msg.AddAttachment("Attachment.pdf", postedFile);
            var response = client.SendEmailAsync(msg);
        }
    }
}