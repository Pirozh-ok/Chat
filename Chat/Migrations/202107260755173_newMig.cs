namespace Chat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserChats", "IdRecipient", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserChats", "IdRecipient");
        }
    }
}
