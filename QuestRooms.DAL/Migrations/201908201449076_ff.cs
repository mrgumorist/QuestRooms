namespace QuestRooms.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ff : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "Logo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "Logo", c => c.String(nullable: false));
        }
    }
}
