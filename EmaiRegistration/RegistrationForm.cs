using System.Net.Mail;
using System.Net;
using EmaiRegistration.Service;

namespace EmaiRegistration
{
    public partial class RegistrationForm : Form
    {    
        //Создаём объект отправки сообщений в почтовый сервис
        EmailService ES;
        //Хранения сгенерированного кода подтверждения
        string confirmation_code = string.Empty;
        public RegistrationForm()
        {
            //Путь к файлу к данным почтового сервиса
            string path = Environment.CurrentDirectory + "\\service-mail";
            //Иницализируем объект
            ES = new EmailService(path);
            InitializeComponent();
        }

        //Событие отправки кода сообщения на указанную почту
        private void Send_Code_Click(object sender, EventArgs e)
        {
            //Генерируем код подтверждения
            confirmation_code = new Random().Next(100000, 999999).ToString();
            //Проверяем корректность почты
            if (tb_Email.Text != "" && (tb_Email.Text.Contains('@') || tb_Email.Text.Contains("ru") || tb_Email.Text.Contains("com")))
            {
                //Отправляем сообщение
                ES.SendEmai(l_Status, "Сonfirmation code sent", tb_Email.Text, "Mail Confirmation Code", $"**{confirmation_code}**");
            }
            else
            {
                //Выводим сообщение, если почта не корректна
                l_Status.Text = "Incorrect Email";
            }
            //Отображаем TextBox для ввода кода
            tb_Confirmed_Code.Visible = true;
        }
        //Событие отображения элементов регистрации
        private void b_New_Registration_Click(object sender, EventArgs e)
        {
            l_User_Name.Visible = true;
            l_Password.Visible = true;
            l_Email.Visible = true;
            l_Status.Visible = true;
            l_Code.Visible = true;
            l_Success.Visible = true;
            tb_User_Name.Visible = true;
            tb_Password.Visible = true;
            tb_Email.Visible = true;
            tb_Confirmed_Code.Visible = true;
            b_Send_Code.Visible = true;
            b_Register.Visible = true;
            b_Cancel.Visible = true;
            b_Get_Code.Visible = true;
        }
        //Событие очистки и скрытия элементов регистрации
        private void b_Cancel_Click(object sender, EventArgs e)
        {
            l_User_Name.Visible = false;
            l_Password.Visible = false;
            l_Email.Visible = false;
            l_Status.Visible = false;
            l_Status.Text = "";
            l_Code.Visible = false;
            l_Success.Visible = false;
            l_Success.Text = "";
            tb_User_Name.Visible = false;
            tb_User_Name.Text = "";
            tb_Password.Visible = false;
            tb_Password.Text = "";
            tb_Email.Visible = false;
            tb_Email.Text = "";
            tb_Confirmed_Code.Visible = false;
            tb_Confirmed_Code.Text = "";
            b_Send_Code.Visible = false;
            b_Register.Visible = false;
            b_Cancel.Visible = false;
            b_Get_Code.Visible = false;
            confirmation_code = "";
            tm_Get_Code.Stop();
        }
        //События проверки заполнения соотвествующих TextBox, путём вызова метода
        private void tb_User_Name_TextChanged(object sender, EventArgs e)
        {
            CheckingFilling();
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            CheckingFilling();
        }

        private void tb_Email_TextChanged(object sender, EventArgs e)
        {
            CheckingFilling();
        }
        private void tb_Confirmed_Code_TextChanged(object sender, EventArgs e)
        {
            CheckingFilling();
        }
        //Событие проверки кода подтверждения и регистрации
        private void b_Register_Click(object sender, EventArgs e)
        {
            //Проверяем код подтверждения
            if (confirmation_code == tb_Confirmed_Code.Text)
            {
                //Выводим сообщени рь удачной регистрации
                l_Success.Text = $"User \"{tb_User_Name.Text}\" successful registration!";
            }
            else
            {
                //Выводим сообщения об неудачной регистрации
                l_Success.Text = $"Verification code is incorrect!";
            }
            tm_Get_Code.Stop();
        }        
        //Событие запуска таймера для периодической проверки почты на получение письма с кодом подтверждения
        private void b_Start_Get_Code_Click(object sender, EventArgs e)
        {
            tm_Get_Code.Start();            
        }
        //Событие вызова метода получения кода подтверждения с сервесной почты и остановки таймера
        private void tm_Get_Code_Tick(object sender, EventArgs e)
        {
            tb_Confirmed_Code.Text = ES.GetEmai(tb_Email.Text);
            tm_Get_Code.Stop();
        }
        //Метод проверки заполнения соответствующих TextBox
        private void CheckingFilling()
        {
            if (tb_Confirmed_Code.Text != "" && tb_User_Name.Text != "" && tb_Password.Text != "" && tb_Email.Text != "")
                //Активируем соответствующую кнопку
                b_Register.Enabled = true;
        }
    }
}
