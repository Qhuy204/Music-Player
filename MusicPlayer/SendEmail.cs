using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public class SendEmail
    {
        public static Random rd = new Random();
        public static int SendMail(string text, string email)
        {
            int code = rd.Next(100000, 999999);
            // Set sender address
            var fromAddress = new MailAddress("musicapplication2@gmail.com"); //Sender

            // Add recipient correctly
            var toAddress = new MailAddress(email); //Receiver 
            const string pass = "vkagacwumrfctuwd";
            // Set subject and body
            const string subject = "MUSIC PLAYER - Your verification code";
            string body = text + "\n" + "Your verification code is: " + code;


            // Send email
            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, pass),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                MessageBox.Show("Authentication code sent successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return code;
        }
    }
}
