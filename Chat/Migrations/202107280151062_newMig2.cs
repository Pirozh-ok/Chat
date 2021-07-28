namespace Chat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserChats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdRecipient = c.Int(nullable: false),
                        Name = c.String(),
                        UserData_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserDatas", t => t.UserData_Id)
                .Index(t => t.UserData_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserChats", "UserData_Id", "dbo.UserDatas");
            DropIndex("dbo.UserChats", new[] { "UserData_Id" });
            DropTable("dbo.UserChats");
        }
    }
}
