namespace Quality.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class supplier : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Piece", "SupplierId", "dbo.Supplier");
            DropIndex("dbo.Piece", new[] { "SupplierId" });
            CreateTable(
                "dbo.ref_Supplier",
                c => new
                    {
                        ref_SupplierId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ref_SupplierId);
            
            AddColumn("dbo.Piece", "ref_SupplierId", c => c.Int(nullable: false));
            CreateIndex("dbo.Piece", "ref_SupplierId");
            AddForeignKey("dbo.Piece", "ref_SupplierId", "dbo.ref_Supplier", "ref_SupplierId", cascadeDelete: true);
            DropColumn("dbo.Piece", "SupplierId");
            DropTable("dbo.Supplier");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            AddColumn("dbo.Piece", "SupplierId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Piece", "ref_SupplierId", "dbo.ref_Supplier");
            DropIndex("dbo.Piece", new[] { "ref_SupplierId" });
            DropColumn("dbo.Piece", "ref_SupplierId");
            DropTable("dbo.ref_Supplier");
            CreateIndex("dbo.Piece", "SupplierId");
            AddForeignKey("dbo.Piece", "SupplierId", "dbo.Supplier", "SupplierId", cascadeDelete: true);
        }
    }
}
