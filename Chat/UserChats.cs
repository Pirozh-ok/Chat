using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chat
{
    public class UserChat
    { 
        [Key]
        public int Id { get; set; }
        public List<int> IdMembers = new List<int>(); 
        public string Name { get; set; }
    }
}
