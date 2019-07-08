namespace Quality.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class imputation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ref_Imputation", "ProductionAreaName", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.ref_Imputation", "ProductionAreaName");
        }
        
        public override void Down()
        {
            DropIndex("dbo.ref_Imputation", new[] { "ProductionAreaName" });
            DropColumn("dbo.ref_Imputation", "ProductionAreaName");
        }
    }
}
