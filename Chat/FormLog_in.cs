using System;
using System.Linq;
using System.Windows.Forms;

namespace Chat
{
    public partial class FormLog_in : Form
    {
        public FormLog_in()
        {
            InitializeComponent();
            SetStartSettings(); 
        }

        /* Установка начальных настроек для textbox с данными. */
        private void SetStartSettings()
        {
            labException.Visible = false;
            panel2.BorderStyle = BorderStyle.None;
            panel3.BorderStyle = BorderStyle.None;
        }

        /* При попытке войти в чат. */ 
        private void button1_Click(object sender, EventArgs e)
        {
            EnterToAccount(); 
        }

        private void EnterToAccount()
        {
            try
            {
                SetStartSettings();

                if (this.tLogin.Text != "" && this.tPassword.Text != "")
                {
                    var login = this.tLogin.Text;
                    var password = this.tPassword.Text;

                    using (var context = new DBContext())
                    {
                        var account = context.UserDatas.Single(x => x.Login == login && x.Password == password);

                        MainFormChat mainFormChat = new MainFormChat();
                        mainFormChat.UserAccount = account;
                        mainFormChat.Show();
                        this.Hide();
                    }
                }
                else
                    throw new FormatException();
            }
            catch (FormatException)
            {
                if (tLogin.Text == "")
                    panel2.BorderStyle = BorderStyle.Fixed3D;

                if (tPassword.Text == "")
                    panel3.BorderStyle = BorderStyle.Fixed3D;

                labException.Visible = true;
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Account not found, please check details and try again");
            }
        }

        /* При регистрации пользователя. */
        private void bSign_up_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormSign_in().Show();
        }

        private void FormLog_in_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
        }

        private void tPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EnterToAccount(); 
        }
    }
}
