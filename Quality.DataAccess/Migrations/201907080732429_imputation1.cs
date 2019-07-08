namespace Quality.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imputation1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ref_Ventilation", "ProductionAreaName", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.ref_Ventilation", "ProductionAreaName");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ref_Ventilation", new[] { "ProductionAreaName" });
            DropColumn("dbo.ref_Ventilation", "ProductionAreaName");
        }
    }
}
