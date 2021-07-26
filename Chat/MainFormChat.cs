using System;
using System.Linq;
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
            lblNotChats.Text = "You don't have any dialogs yet. \r\n\tStart chatting right now!";

            using (var contex = new DBContext())
            {
                var currentUser = contex.UserChats.Single()
                if (UserAccount.ListUserChats.Count != 0)
                {
                    Controls.Remove(bStartChat);

                    foreach (var chats in UserAccount.ListUserChats)
                    {
                        lbAllChat.Items.Add(chats.Name);
                    }
                }
            }
        }

        private void tbSearchChat_Click(object sender, EventArgs e)
        {
            tbSearchChat.Text = string.Empty; 
        }

        private void bStartChat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new CreatNewChat();
            newForm.UserAccount = this.UserAccount; 
            newForm.Show();
        }

        private void bYourProfile_Click(object sender, EventArgs e)
        {
            var formProfile = new FormAboutMyProfile();
            formProfile.UserAccount = this.UserAccount;
            //formProfile.TopMost = true; 
            formProfile.ShowDialog();
        }
    }
}
