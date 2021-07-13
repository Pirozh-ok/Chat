using System;
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

        private void SetStartSettings()
        {
            labException.Visible = false;
            panel2.BorderStyle = BorderStyle.None;
            panel3.BorderStyle = BorderStyle.None;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SetStartSettings(); 

                if (this.tLogin.Text != "" && this.tPassword.Text != "")
                {
                    bool isCheck = false; 
                    var login = this.tLogin.Text;
                    var password = this.tPassword.Text;
                    var accountInfo = new UserData(); 

                    using (var context = new DBContext())
                    { 
                        foreach(var account in context.UserDatas)
                            if(account.Login == login && account.Password == password)
                            {
                                accountInfo = account;
                                MessageBox.Show("Выполняю вход");
                                isCheck = true; 
                                break; 
                            }

                        if (!isCheck)
                        {
                            MessageBox.Show("Account not found, please check details and try again");
                        }
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

        }

        private void bSign_up_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormSign_in().Show();
        }

        private void FormLog_in_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
        }
    }
}
