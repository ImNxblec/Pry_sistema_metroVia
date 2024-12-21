using System;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pry_sistema_metroVia.Metodos
{
    internal class EmailSender
    {
        public bool SendEmail(string toEmail, string subject, string body, string attachmentPath)
        {
            try
            {
                string smtpServer = "smtp.gmail.com";  // Cambia esto por el servidor SMTP adecuado
                int smtpPort = 587;
                string fromEmail = "tu_correo@gmail.com";  // Cambia esto por tu correo
                string fromPassword = "tu_contraseña";

                SmtpClient smtpClient = new SmtpClient(smtpServer)
                {
                    Port = smtpPort,
                    Credentials = new NetworkCredential(fromEmail, fromPassword),
                    EnableSsl = true
                };

                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(fromEmail),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };

                mail.To.Add(toEmail);

                if (!string.IsNullOrEmpty(attachmentPath) && System.IO.File.Exists(attachmentPath))
                {
                    Attachment attachment = new Attachment(attachmentPath);
                    mail.Attachments.Add(attachment);
                }
                else
                {
                    Console.WriteLine("No se encuentra el archivo adjunto");
                }

                smtpClient.Send(mail);

                Console.WriteLine("Correo enviado con éxito");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar el correo: " + ex.Message);
                return false;
            }
        }
    }
}
