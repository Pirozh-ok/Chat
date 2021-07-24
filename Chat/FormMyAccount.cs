using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    public partial class FormAboutMyProfile : Form
    {
        public UserData UserAccount { get; set; }
        public FormAboutMyProfile()
        {
            InitializeComponent();
        }

        private void FormAboutMyProfile_Load(object sender, EventArgs e)
        {
            lblUserName.Text += UserAccount.UserName;
            lblGender.Text += ((Sex)UserAccount.Sex).ToString();
            lblRegDate.Text += UserAccount.DateRegister.ToShortDateString();
            lblLogin.Text += UserAccount.Login;
            lblPassword.Text += UserAccount.Password; 
        }
    }
}
