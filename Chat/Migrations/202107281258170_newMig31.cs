namespace Chat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMig31 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserChats", "TimeLastMsg", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserChats", "TimeLastMsg");
        }
    }
}
