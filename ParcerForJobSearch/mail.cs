using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ParcerForJobSearch
{
    class mail
    {
        // Имя или e-mail
        private string nameAuthor = "";
        // Тема разовора
        private string subject = "";
        // Описание проблемы
        private string bodyMail = "";
        // Мой пароль от почты mail.ru
        protected private string passMail = "Qxbc4dfd";

        public mail(string nameAuthor, string subject, string bodyMail)
        {
            // Данном случае, this будет обозначать ссылку на сам объект
            this.nameAuthor = nameAuthor;
            this.subject = subject;
            this.bodyMail = bodyMail;
        }

        public void MySendMail()
        {
            var from = new MailAddress("minotraur@mail.ru", nameAuthor); // Почта для отправки сообщений
            var to = new MailAddress("fedotov85050@gmail.com", "Влад Федотов"); //Моя почта

            try
            {
                // Предаем адрес smtp сервера и порт
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
                // Обращение к smtp серверу будет осуществлять по сети
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                // Передаем параметры доступа
                smtp.Credentials = new NetworkCredential(from.Address, passMail);
                smtp.EnableSsl = true;
                smtp.Timeout = 1000;

                // С какого ящика нужно отправить и на какой доставить
                MailMessage mail = new MailMessage(from, to);
                // Добавляем, тему и тело в сообщение
                mail.Subject = subject;
                mail.Body = bodyMail;

                smtp.Send(mail);

                MessageBox.Show("Сообщение отправлено!", "Информационное письмо", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка отправки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
