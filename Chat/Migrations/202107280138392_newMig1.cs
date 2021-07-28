namespace Chat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMig1 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.UserChats");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserChats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdRecipient = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
