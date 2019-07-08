namespace Quality.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cqb : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ref_CQ", "IsSupplierCQ", c => c.Boolean());
            AlterColumn("dbo.ref_CQ", "IsRyoCQ", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ref_CQ", "IsRyoCQ", c => c.Boolean(nullable: false));
            AlterColumn("dbo.ref_CQ", "IsSupplierCQ", c => c.Boolean(nullable: false));
        }
    }
}
