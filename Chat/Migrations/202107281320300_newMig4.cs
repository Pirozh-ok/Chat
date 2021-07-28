namespace Chat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newMig4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserChats", "TimeLastMsg", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserChats", "TimeLastMsg", c => c.DateTime(nullable: false));
        }
    }
}
