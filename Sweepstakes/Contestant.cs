using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Sweepstakes
{
    class Contestant
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string EmailAddress
        {
            get;
            set;
        }

        public int RegistrationNumber
        {
            get;
            set;
        }

        public Contestant() //may not be correct implementation
        {
            UserInterface.AssignContestantInfo(this);
        }

        public void Notify(Contestant winner)
        {
            UserInterface.Notify(winner);
        }

        public void NotifyWinner(Contestant winner) //Test this! Especially the email portion
        {
            UserInterface.NotifyWinner(winner);

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sweepstakes Office", "noreply@gmail.com"));
            message.To.Add(new MailboxAddress(winner.FirstName + " " + winner.LastName, winner.EmailAddress));
            message.Subject = "You Won!";

            message.Body = new TextPart("plain")
            {
                Text = @"Hey, you won the sweepstakes!"
            };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587);

                client.AuthenticationMechanisms.Remove("XOAUTH2");

                client.Authenticate("depmike63@gmail.com", ""); //should be changed to sending 

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
