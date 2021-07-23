namespace Chat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MessagesChats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        DateSend = c.DateTime(nullable: false),
                        IdSender = c.Int(nullable: false),
                        IdRecipient = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserChats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        UserData_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserDatas", t => t.UserData_Id)
                .Index(t => t.UserData_Id);
            
            CreateTable(
                "dbo.UserDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        UserName = c.String(),
                        DateRegister = c.DateTime(nullable: false),
                        Sex = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserChats", "UserData_Id", "dbo.UserDatas");
            DropIndex("dbo.UserChats", new[] { "UserData_Id" });
            DropTable("dbo.UserDatas");
            DropTable("dbo.UserChats");
            DropTable("dbo.MessagesChats");
        }
    }
}
