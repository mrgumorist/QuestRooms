namespace QuestRooms.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_numberhouse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adresses", "HouseNum", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Adresses", "HouseNum");
        }
    }
}
