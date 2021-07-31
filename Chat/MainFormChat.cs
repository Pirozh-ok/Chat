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

            using (var context = new DBContext())
            {
                /*context.UserChats.RemoveRange(context.UserChats);
                context.SaveChanges();*/

                /*Получаем из базы данных список чатов, которые существуют у пользователя, сортированный по дате последнего сообщения в этом чате. */
                ListChats = context.UserChats.Include(d => d.User)
                                             .Where(x=>x.UserID == UserAccount.Id)
                                             .OrderByDescending(x => x.TimeLastMsg).ToList();
                
                if (ListChats.Count != 0)
                {
                    lblNotChats.Visible = false;
                    bStartChat.Location = new System.Drawing.Point(95, 400);

                    foreach (var chat in ListChats)
                    {
                        lbAllChat.Items.Add(chat.Name);
                    }
                    this.lblSelectChat.Visible = false; 
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

        private void lbAllChat_MouseClick(object sender, MouseEventArgs e)
        {
            if (lbAllChat.SelectedItem != null)
                MessageBox.Show("Test");
            else lbAllChat.SelectedItem = null; 
        }
    }
}
