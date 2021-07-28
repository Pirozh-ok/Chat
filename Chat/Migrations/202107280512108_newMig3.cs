namespace Chat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMig3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.UserChats", name: "UserData_Id", newName: "UserID");
            RenameIndex(table: "dbo.UserChats", name: "IX_UserData_Id", newName: "IX_UserID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.UserChats", name: "IX_UserID", newName: "IX_UserData_Id");
            RenameColumn(table: "dbo.UserChats", name: "UserID", newName: "UserData_Id");
        }
    }
}
