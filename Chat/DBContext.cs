using System.Data.Entity;

namespace Chat
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DbConnectionString")
        { }
        public DbSet<UserData> UserDatas { get; set; }
        public DbSet<MessagesChats> Messages { get; set; }
        public DbSet<UserChat> UserChats { get; set; }
    }
}
