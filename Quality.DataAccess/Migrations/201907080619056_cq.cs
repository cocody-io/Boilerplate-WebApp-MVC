namespace Quality.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cq : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ref_CQ", "Code", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ref_CQ", "Code");
        }
    }
}
