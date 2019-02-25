namespace LeaveRequestWebAPI.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDateHoliday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Holidays", "DateTime", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Holidays", "DateTime");
        }
    }
}
