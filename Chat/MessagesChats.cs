using System;
using System.ComponentModel.DataAnnotations;

namespace Chat
{
    public class MessagesChats
    {
        [Key] 
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime DateSend { get; set; }
        public int IdSender { get; set; }
        public int IdRecipient { get; set; }
    }
}
