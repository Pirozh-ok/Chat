using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chat
{
    public class UserChat
    { 
        [Key]
        public int Id { get; set; }
        public int IdRecipient { get; set; } 
        public string Name { get; set; }
        public DateTime? TimeLastMsg { get; set; }
        public int? UserID { get; set; }
        public UserData User { get; set; }
    }
}
