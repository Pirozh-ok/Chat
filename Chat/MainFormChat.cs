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
                if (UserAccount.ListUserChats.Count != 0)
                {
                    bStartChat.Visible = false;
                    bStartChat.Enabled = false;
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
            MessageBox.Show("Нажата кнопка начать общение!");
            // форма добавления чата
        }
    }
}
