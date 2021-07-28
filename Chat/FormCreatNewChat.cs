using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Chat
{
    public partial class CreatNewChat : Form
    {
        public UserData UserAccount { get; set; }
        private List<int> ListIdSearchUsers = new List<int>();
        public CreatNewChat()
        {
            InitializeComponent();
        }

        /*При загрузке формы. */
        private void CreatNewChat_Load(object sender, EventArgs e)
        {
            this.Hide();

            using (var context = new DBContext())
            {
                foreach (var user in context.UserDatas)
                {
                    if (user != UserAccount)
                    {
                        lbSearchMembers.Items.Add(user.UserName);
                        ListIdSearchUsers.Add(user.Id);
                    }
                }
            }

            this.Hide(); 
        }

        private void tbSearchChat_Click(object sender, EventArgs e)
        {
            tbSearchChat.Text = string.Empty; 
        }

        private void tbSearchChat_MouseLeave(object sender, EventArgs e)
        {
            if (tbSearchChat.Text == string.Empty)
                tbSearchChat.Text = "Search: ";
        }

        /*При изменение строки поиска человека*/
        private void tbSearchChat_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchChat.Text == string.Empty || tbSearchChat.Text == "Search: ")
                return;

            int countSearch = 0;

            lblNoFound.Visible = false;
            lbSearchMembers.Items.Clear(); 
            ListIdSearchUsers.Clear(); 

            using (var context = new DBContext())
            {
                /* Выбираем из списка всех пользователей только тех, кто соответствует введёной пользователей строке и чтоб они не совпадали
                 с текущим аккаунтом пользователя. */
                var users = context.UserDatas.Where(x => x.UserName.ToUpper().Contains(tbSearchChat.Text.ToUpper()) && x.Id != this.UserAccount.Id);

                foreach (var user in users)
                {
                        countSearch++; 
                        lbSearchMembers.Items.Add(user.UserName);
                        ListIdSearchUsers.Add(user.Id);                 
                }

                /*foreach (var user in context.UserDatas)
                {
                    if (user.UserName.ToUpper().Contains(tbSearchChat.Text.ToUpper()) && user != this.UserAccount)
                    {
                        countSearch++; 
                        lbSearchMembers.Items.Add(user.UserName);
                        ListIdSearchUsers.Add(user.Id);
                    }
                }*/

                if (countSearch == 0)
                {
                    lblNoFound.Visible = true; 
                }
            } 
        }

        private void CreatNewChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new MainFormChat();
            newForm.UserAccount = this.UserAccount;
            newForm.Show();
            this.Hide();
        }

        /*При клике на создание чата*/
        private void bCreatChat_Click(object sender, EventArgs e)
        {
            if (lbSearchMembers.SelectedItem != null)
            {
                var IdUserForChat = ListIdSearchUsers[lbSearchMembers.SelectedIndex];

                using (var context = new DBContext())
                {
                    var currentUser = context.UserDatas.Single(x=> x.Id == UserAccount.Id);

                    currentUser.ListUserChats.Add(new UserChat()
                    {
                        IdRecipient = ListIdSearchUsers[IdUserForChat],
                        Name = context.UserDatas.Single(x => x.Id == IdUserForChat).UserName,
                        TimeLastMsg = DateTime.Now,
                        User = currentUser
                    });
                    context.SaveChanges();

                    UserAccount = currentUser;                  
                }

                var newForm = new MainFormChat();
                newForm.UserAccount = this.UserAccount;
                newForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Choose a recipient!");
        }
    }
}
