namespace MVCMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TotalGross : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "TotalGross", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "TotalGross");
        }
    }
}
