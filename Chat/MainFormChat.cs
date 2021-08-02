using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Chat
{
    public partial class MainFormChat : Form
    {
        public UserData UserAccount { get; set; }
        private List<UserChat> ListChats { get; set; } = new List<UserChat>();
        private UserChat CurrentChat { get; set; }
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
                                             .Where(x => x.UserID == UserAccount.Id)
                                             .OrderByDescending(x => x.TimeLastMsg).ToList();

                if (ListChats.Count != 0)
                {
                    lblNotChats.Visible = false;
                    bStartChat.Location = new System.Drawing.Point(95, 400);

                    foreach (var chat in ListChats)
                    {
                        lbAllChat.Items.Add(chat.Name);
                    }
                    this.lblSelectChat.Visible = true;
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
        private void tMsg_MouseClick(object sender, MouseEventArgs e)
        {
            if (tMsg.Text == "Enter message: ")
                tMsg.Text = string.Empty;
        }

        private void tMsg_MouseLeave(object sender, EventArgs e)
        {
            if (tMsg.Text == string.Empty)
                tMsg.Text = "Enter message: ";
        }

        private void tMsg_TextChanged(object sender, EventArgs e)
        {
            if (tMsg.Text == string.Empty || tMsg.Text == "Enter message: ")
                bSendMsg.Enabled = false;
            else bSendMsg.Enabled = true;
        }

        private string FormatStringForMsg(MessagesChats msg)
        {
            using (var context = new DBContext())
            {
                return msg.DateSend.ToShortTimeString() + " " + context.UserDatas.Single(x => x.Id == msg.IdSender).UserName + ": " + msg.Message;
            }
        }
        private void SendMsg()
        {
            lblNotMsg.Visible = false;

            using (var context = new DBContext())
            {
                var newMsg = new MessagesChats()
                {
                    Message = tMsg.Text,
                    DateSend = DateTime.Now,
                    IdSender = UserAccount.Id,
                    IdRecipient = CurrentChat.IdRecipient
                };

                /* Обновляем время отправки последнего сообщений в чате. */
                var currChat = context.UserChats.Single(x => x.Id == CurrentChat.Id);
                currChat.TimeLastMsg = newMsg.DateSend;
                CurrentChat = currChat;

                context.Messages.Add(newMsg);
                context.SaveChanges();
                lbCurrentChat.Items.Add(FormatStringForMsg(newMsg));
            }

            tMsg.Text = string.Empty;
        }

        private void tMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendMsg();
        }

        private void bSendMsg_Click(object sender, EventArgs e)
        {
            SendMsg();
        }

        private async void lbAllChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAllChat.SelectedItem == null)
                return;

            await Task.Run(() => CheckNewMsg());

            lblSelectChat.Visible = false;
            lbCurrentChat.Items.Clear();

            using (var context = new DBContext())
            {
                CurrentChat = context.UserChats.ToList().Single(x => x.Id == ListChats[lbAllChat.SelectedIndex].Id); 

                var ListMsg = context.Messages.Where(x => x.IdSender == UserAccount.Id && x.IdRecipient == CurrentChat.IdRecipient
                                                       || x.IdSender == CurrentChat.IdRecipient && x.IdRecipient == UserAccount.Id).ToList();

                /*var ListNewMsg = context.Messages.Where(x => (x.DateSend > CurrentChat.TimeLastMsg) && (x.IdSender == UserAccount.Id && x.IdRecipient == CurrentChat.IdRecipient
                                                                   || x.IdSender == CurrentChat.IdRecipient && x.IdRecipient == UserAccount.Id)).ToList();*/

                tMsg.Visible = true;
                tMsg.Enabled = true;
                bSendMsg.Visible = true;

                if (ListMsg.Count == 0)
                {
                    lblNotMsg.Visible = true;
                    return;
                }

                foreach (var msg in ListMsg)
                {
                    lbCurrentChat.Items.Add(FormatStringForMsg(msg));
                }
            }
        }

        private void CheckNewMsg()
        {
            while (true)
            {
                Thread.Sleep(5000);
                using (var context = new DBContext())
                {
                    var ListNewMsg = context.Messages.Where(x => (x.DateSend > CurrentChat.TimeLastMsg) 
                                                        && (x.IdSender == UserAccount.Id && x.IdRecipient == CurrentChat.IdRecipient
                                                         || x.IdSender == CurrentChat.IdRecipient && x.IdRecipient == UserAccount.Id)).ToList(); 
                    
                    if (ListNewMsg.Count != 0)
                    {
                        foreach (var msg in ListNewMsg)
                            lbCurrentChat.Items.Add(FormatStringForMsg(msg));
                    }

                }
            }
        }
    }
}
