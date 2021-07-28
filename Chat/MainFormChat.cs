using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Collections.Generic;

namespace Chat
{
    public partial class MainFormChat : Form
    {
        public UserData UserAccount { get; set; }
        private List <UserChat> ListChats { get; set; } = new List<UserChat>();
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
                ListChats = contex.UserChats.Include(d => d.User).ToList();
                var SortListChats = ListChats.OrderByDescending(x => x.TimeLastMsg); 

                if (ListChats.Count != 0)
                {
                    lblNotChats.Visible = false;
                    bStartChat.Location = new System.Drawing.Point(108, 502);

                    foreach (var chat in ListChats)
                    {
                        lbAllChat.Items.Add(chat.Name);
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
            formProfile.ShowDialog();
        }
    }
}
