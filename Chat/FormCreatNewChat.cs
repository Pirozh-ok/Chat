using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;

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
                var ListChat = context.UserChats.Include(d=>d.User)
                                                .Where(d => d.UserID == UserAccount.Id).ToList();

                foreach (var user in context.UserDatas)
                {
                    if (user.Id != UserAccount.Id)
                    {
                        /*Ищем в списке чатов пользователя чат с каждым найденным пользователем, если его нет, 
                     * то отображаем пользователя в списке тех, с кем можно начать чат. */
                        try
                        {
                            ListChat.Single(x => x.IdRecipient == user.Id);
                        }
                        catch (InvalidOperationException)
                        {
                            {
                                lbSearchMembers.Items.Add(user.UserName);
                                ListIdSearchUsers.Add(user.Id);
                            }
                        }
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
                var users = context.UserDatas.Where(x => x.UserName.ToUpper().Contains(tbSearchChat.Text.ToUpper()) && x.Id != this.UserAccount.Id).ToList();

                /* Подгружаем список всех чатов пользователя. */
                var ListChat = context.UserChats.Include(d => d.User)
                                                .Where(d=>d.UserID == UserAccount.Id).ToList();
            
                foreach (var user in users)
                {
                    /*Ищем в списке чатов пользователя чат с каждым найденным пользователем, если его нет, 
                     * то отображаем пользователя в списке тех, с кем можно начать чат. */
                    try
                    {
                        ListChat.Single(x => x.IdRecipient == user.Id);
                    }
                    catch (InvalidOperationException)
                    {
                        {
                            lbSearchMembers.Items.Add(user.UserName);
                            ListIdSearchUsers.Add(user.Id);
                            countSearch++;
                        }
                    }                 
                }

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
                    var userForChat = context.UserDatas.Single(x => x.Id == IdUserForChat);

                    /*Добавляем диалог в БД у обоих собеседников*/
                    currentUser.ListUserChats.Add(new UserChat()
                    {
                        IdRecipient = userForChat.Id,
                        Name = userForChat.UserName,
                        TimeLastMsg = DateTime.Now,
                        User = currentUser
                    });

                    userForChat.ListUserChats.Add(new UserChat()
                    {
                        IdRecipient = UserAccount.Id,
                        Name = UserAccount.UserName,
                        TimeLastMsg = DateTime.Now,
                        User = userForChat
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
