using System;
using System.Windows.Forms;

namespace Chat
{
    public partial class MainFormChat : Form
    {
        public UserData UserAccount { get; set; }
        public MainFormChat()
        {
            InitializeComponent();
        }

        private void MainFormChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        /* Инициализация формы данными аккаунта при её загрузке. */
        private void MainFormChat_Load(object sender, EventArgs e)
        {
            lblUserName.Text = UserAccount.UserName;
            lbAllChat.Items.Add("первый чат"); 
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");
            lbAllChat.Items.Add("первый чат");

            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
            lbCurrentChat.Items.Add("второй чат");
        }

        private void tbSearchChat_Click(object sender, EventArgs e)
        {
            tbSearchChat.Text = string.Empty; 
        }
    }
}
