namespace LeaveRequestWebAPI.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addModelKasimMode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(),
                        Address = c.String(),
                        Marriage = c.String(),
                        ChildrenTotal = c.Int(nullable: false),
                        LastYear = c.Int(nullable: false),
                        ThisYear = c.Int(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        Picture = c.String(),
                        JoinDate = c.DateTimeOffset(nullable: false, precision: 7),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Divisions_Id = c.Int(),
                        Managers_Id = c.Int(),
                        Positions_Id = c.Int(),
                        Religions_Id = c.Int(),
                        Villages_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Divisions", t => t.Divisions_Id)
                .ForeignKey("dbo.Employees", t => t.Managers_Id)
                .ForeignKey("dbo.Positions", t => t.Positions_Id)
                .ForeignKey("dbo.Religions", t => t.Religions_Id)
                .ForeignKey("dbo.Villages", t => t.Villages_Id)
                .Index(t => t.Divisions_Id)
                .Index(t => t.Managers_Id)
                .Index(t => t.Positions_Id)
                .Index(t => t.Religions_Id)
                .Index(t => t.Villages_Id);
            
            CreateTable(
                "dbo.Religions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Leaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Status = c.String(),
                        Days = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LogDate = c.DateTimeOffset(nullable: false, precision: 7),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Employees_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employees_Id)
                .Index(t => t.Employees_Id);
            
            CreateTable(
                "dbo.TakeLeaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        DateStart = c.DateTimeOffset(nullable: false, precision: 7),
                        DateEnd = c.DateTimeOffset(nullable: false, precision: 7),
                        ApprovalStatus = c.String(),
                        Difference = c.Int(nullable: false),
                        DateStartSpecial = c.DateTimeOffset(nullable: false, precision: 7),
                        DateEndSpecial = c.DateTimeOffset(nullable: false, precision: 7),
                        DifferenceSpecial = c.Int(nullable: false),
                        CreateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        UpdateDate = c.DateTimeOffset(nullable: false, precision: 7),
                        DeleteDate = c.DateTimeOffset(nullable: false, precision: 7),
                        IsDelete = c.Boolean(nullable: false),
                        Employees_Id = c.Int(),
                        Leaves_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.Employees_Id)
                .ForeignKey("dbo.Leaves", t => t.Leaves_Id)
                .Index(t => t.Employees_Id)
                .Index(t => t.Leaves_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TakeLeaves", "Leaves_Id", "dbo.Leaves");
            DropForeignKey("dbo.TakeLeaves", "Employees_Id", "dbo.Employees");
            DropForeignKey("dbo.Logs", "Employees_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Villages_Id", "dbo.Villages");
            DropForeignKey("dbo.Employees", "Religions_Id", "dbo.Religions");
            DropForeignKey("dbo.Employees", "Positions_Id", "dbo.Positions");
            DropForeignKey("dbo.Employees", "Managers_Id", "dbo.Employees");
            DropForeignKey("dbo.Employees", "Divisions_Id", "dbo.Divisions");
            DropIndex("dbo.TakeLeaves", new[] { "Leaves_Id" });
            DropIndex("dbo.TakeLeaves", new[] { "Employees_Id" });
            DropIndex("dbo.Logs", new[] { "Employees_Id" });
            DropIndex("dbo.Employees", new[] { "Villages_Id" });
            DropIndex("dbo.Employees", new[] { "Religions_Id" });
            DropIndex("dbo.Employees", new[] { "Positions_Id" });
            DropIndex("dbo.Employees", new[] { "Managers_Id" });
            DropIndex("dbo.Employees", new[] { "Divisions_Id" });
            DropTable("dbo.TakeLeaves");
            DropTable("dbo.Logs");
            DropTable("dbo.Leaves");
            DropTable("dbo.Religions");
            DropTable("dbo.Employees");
        }
    }
}
