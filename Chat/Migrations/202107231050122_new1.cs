namespace Chat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class new1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserChats", "UserData_Id", "dbo.UserDatas");
            DropIndex("dbo.UserChats", new[] { "UserData_Id" });
            DropColumn("dbo.UserChats", "UserData_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserChats", "UserData_Id", c => c.Int());
            CreateIndex("dbo.UserChats", "UserData_Id");
            AddForeignKey("dbo.UserChats", "UserData_Id", "dbo.UserDatas", "Id");
        }
    }
}
