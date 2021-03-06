using System;
using System.Collections.Generic;

namespace Chat
{
    public class UserData
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public string UserName {get;set;}
        public DateTime DateRegister { get; set; }
        public Sex? Sex { get; set; }
        public ICollection<UserChat> ListUserChats { get; set;}
        public UserData()
        {
            ListUserChats = new List<UserChat>();
        }
    }
}
