using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Org.BouncyCastle.Crypto;
using MailKit.Security;
using MailKit;

namespace EmaiRegistration.Service
{
    //Класс отправки сообщений в почтовый сервис
    internal class Email_Service
    {
        //Пароль почтового сервиса
        string Password { get; set; }
        //Адрес почтового сервиса
        string ServiceMail { get; set; }
        //Путь к файлу к данным почтового сервиса
        string path = Environment.CurrentDirectory + "\\service-mail";

        public Email_Service() 
        {
            //Получаем данный почтового сервиса(адрес и пароль)
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string[] mail_data = new string[2];              
                for (int i = 0; (line = reader.ReadLine()) != null; i++)              
                {
                    mail_data[i] = line;
                }
                Password = mail_data[0].Split(' ')[1];
                ServiceMail = mail_data[1].Split(' ')[1];
            }
        }
        //Метод создания и отправки сообщения письма
        //label - Label для вывода результат отправки сообщения
        //label_message - сообщение для отображения в Label
        //to_email - адрес почты для отправки письма
        //topic - заголовок письма
        //message - содержимое письма
        public async Task SendEmai(Label label, string label_message, string to_email, string topic, string message)
        {
            try
            {
                SmtpClient client = new SmtpClient("smpt.mail.ru", 587);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(ServiceMail, Password);
                await client.SendMailAsync(ServiceMail, to_email, topic, message);
                label.Text = label_message;
            }
            catch(Exception ex)
            {
                label.Text = $"Something wrong: {ex.Message}";
            }
        }
        //Модет получения сообщения из почтового сервиса
        //email - адрес почты пользователя
        public string GetEmai(string email)
        {
            //Хранение кода подтверждения полученного из почты
            string received_code = "";
            //Хранение адреса почты отправителя
            string from_email = "";
            try 
            { 
                using (var client = new MailKit.Net.Imap.ImapClient())
                {
                    //Подключаемся к почтовому сервису
                    client.Connect("imap.mail.ru", 993, SecureSocketOptions.SslOnConnect);
                    //Авторизуемся на почтовом сервисе
                    client.Authenticate(ServiceMail, Password);
                    //Открываем почту с правами на чтени и запись
                    client.Inbox.Open(MailKit.FolderAccess.ReadWrite);
                    //Прожодимся по всему списку писем на почте
                    for (int i = 0; i<client.Inbox.Count; i++) 
                    {
                        //Получаем почту отправителя по ID
                        from_email = client.Inbox.GetMessage(i).From.Mailboxes.First().Address;
                        //Проверяем соответствует ли почта при регистрации
                        if (from_email == email)
                        { 
                            //Получаем код из тела письма по ID
                            received_code = client.Inbox.GetMessage(i).TextBody.Split("**")[1];
                            // Удаляем письмо из сервиса
                            client.Inbox.AddFlags(i, MailKit.MessageFlags.Deleted, false);
                            break;
                        }                        
                    }                   
                }
            }
            catch(Exception ex)
            {
                //Возвращаем сообщение об ошибки
                received_code = $"Код не получен {ex}";
            }
            //Возвращаем код
            return received_code;
        }
    }
}
