using System;

namespace Chat
{
    public class UserData
    {
        public int Id { get; set; }
        public string UserName {get;set;}
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime? DateRegister { get; set; }
        public sex? Sex { get; set; }
    }
}
