namespace Quality.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Anomaly",
                c => new
                    {
                        AnomalyId = c.Int(nullable: false, identity: true),
                        CreationDate = c.DateTime(nullable: false),
                        ref_ProductionAreaId = c.Int(nullable: false),
                        PieceId = c.Int(),
                    })
                .PrimaryKey(t => t.AnomalyId)
                .ForeignKey("dbo.Piece", t => t.PieceId)
                .ForeignKey("dbo.ref_ProductionArea", t => t.ref_ProductionAreaId, cascadeDelete: true)
                .Index(t => t.ref_ProductionAreaId)
                .Index(t => t.PieceId);
            
            CreateTable(
                "dbo.H",
                c => new
                    {
                        HId = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        PersonId = c.Int(nullable: false),
                        BarCodeUp = c.String(),
                        BarCodeDown = c.String(),
                        NkId = c.Int(nullable: false),
                        NkDate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HId)
                .ForeignKey("dbo.Anomaly", t => t.HId)
                .Index(t => t.HId);
            
            CreateTable(
                "dbo.HCQ",
                c => new
                    {
                        HCQId = c.Int(nullable: false, identity: true),
                        Duration = c.Int(),
                        Weight = c.Int(),
                        HId = c.Int(nullable: false),
                        ref_CQId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.HCQId)
                .ForeignKey("dbo.H", t => t.HId, cascadeDelete: true)
                .ForeignKey("dbo.ref_CQ", t => t.ref_CQId, cascadeDelete: true)
                .Index(t => t.HId)
                .Index(t => t.ref_CQId);
            
            CreateTable(
                "dbo.ref_CQ",
                c => new
                    {
                        ref_CQId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ProductionAreaName = c.String(nullable: false, maxLength: 50),
                        IsSupplierCQ = c.Boolean(),
                        IsRyoCQ = c.Boolean(),
                        Code = c.Int(),
                    })
                .PrimaryKey(t => t.ref_CQId)
                .Index(t => t.ProductionAreaName);
            
            CreateTable(
                "dbo.Expertise",
                c => new
                    {
                        ExpertiseId = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        ref_CauseZEId = c.Int(nullable: false),
                        ref_VentilationId = c.Int(nullable: false),
                        ref_ImputationId = c.Int(nullable: false),
                        PafId = c.Int(),
                        NocoId = c.Int(),
                        ref_CQId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExpertiseId)
                .ForeignKey("dbo.Noco", t => t.NocoId)
                .ForeignKey("dbo.Paf", t => t.PafId)
                .ForeignKey("dbo.ref_CauseZE", t => t.ref_CauseZEId, cascadeDelete: true)
                .ForeignKey("dbo.ref_CQ", t => t.ref_CQId, cascadeDelete: true)
                .ForeignKey("dbo.ref_Imputation", t => t.ref_ImputationId, cascadeDelete: true)
                .ForeignKey("dbo.ref_Ventilation", t => t.ref_VentilationId, cascadeDelete: true)
                .ForeignKey("dbo.TicketNC", t => t.ExpertiseId)
                .Index(t => t.ExpertiseId)
                .Index(t => t.ref_CauseZEId)
                .Index(t => t.ref_VentilationId)
                .Index(t => t.ref_ImputationId)
                .Index(t => t.PafId)
                .Index(t => t.NocoId)
                .Index(t => t.ref_CQId);
            
            CreateTable(
                "dbo.Noco",
                c => new
                    {
                        NocoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.NocoId);
            
            CreateTable(
                "dbo.Paf",
                c => new
                    {
                        PafId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PafId);
            
            CreateTable(
                "dbo.ref_CauseZE",
                c => new
                    {
                        ref_CauseZEId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        ProductionAreaName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ref_CauseZEId)
                .Index(t => t.ProductionAreaName);
            
            CreateTable(
                "dbo.ref_Imputation",
                c => new
                    {
                        ref_ImputationId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        ProductionAreaName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ref_ImputationId)
                .Index(t => t.ProductionAreaName);
            
            CreateTable(
                "dbo.ref_Ventilation",
                c => new
                    {
                        ref_VentilationId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        ProductionAreaName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ref_VentilationId)
                .Index(t => t.ProductionAreaName);
            
            CreateTable(
                "dbo.TicketNC",
                c => new
                    {
                        TicketNCId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        PersonGroupId = c.Int(nullable: false),
                        ManufacturedDate = c.DateTime(nullable: false),
                        Observation = c.String(),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Order = c.Int(),
                        ref_MachineId = c.Int(nullable: false),
                        ref_ProductCodeId = c.Int(nullable: false),
                        ref_ProductTypeId = c.Int(nullable: false),
                        ref_PieceTypeId = c.Int(nullable: false),
                        ref_UnitId = c.Int(nullable: false),
                        ref_CQId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TicketNCId)
                .ForeignKey("dbo.Anomaly", t => t.TicketNCId)
                .ForeignKey("dbo.ref_CQ", t => t.ref_CQId, cascadeDelete: true)
                .ForeignKey("dbo.ref_Machine", t => t.ref_MachineId, cascadeDelete: true)
                .ForeignKey("dbo.ref_PieceType", t => t.ref_PieceTypeId, cascadeDelete: true)
                .ForeignKey("dbo.ref_ProductCode", t => t.ref_ProductCodeId, cascadeDelete: true)
                .ForeignKey("dbo.ref_ProductType", t => t.ref_ProductTypeId, cascadeDelete: true)
                .ForeignKey("dbo.ref_Unit", t => t.ref_UnitId, cascadeDelete: true)
                .Index(t => t.TicketNCId)
                .Index(t => t.ref_MachineId)
                .Index(t => t.ref_ProductCodeId)
                .Index(t => t.ref_ProductTypeId)
                .Index(t => t.ref_PieceTypeId)
                .Index(t => t.ref_UnitId)
                .Index(t => t.ref_CQId);
            
            CreateTable(
                "dbo.ref_Machine",
                c => new
                    {
                        ref_MachineId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Code = c.String(nullable: false, maxLength: 90),
                        ProductionAreaName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ref_MachineId)
                .Index(t => t.ProductionAreaName);
            
            CreateTable(
                "dbo.ref_PieceType",
                c => new
                    {
                        ref_PieceTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                    })
                .PrimaryKey(t => t.ref_PieceTypeId);
            
            CreateTable(
                "dbo.ref_ProductCode",
                c => new
                    {
                        ref_ProductCodeId = c.Int(nullable: false, identity: true),
                        Code = c.String(nullable: false, maxLength: 90),
                    })
                .PrimaryKey(t => t.ref_ProductCodeId);
            
            CreateTable(
                "dbo.ref_ProductType",
                c => new
                    {
                        ref_ProductTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 90),
                    })
                .PrimaryKey(t => t.ref_ProductTypeId);
            
            CreateTable(
                "dbo.ref_Unit",
                c => new
                    {
                        ref_UnitId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ref_UnitId);
            
            CreateTable(
                "dbo.Piece",
                c => new
                    {
                        PieceId = c.Int(nullable: false, identity: true),
                        Identifier = c.String(maxLength: 250),
                        ref_SupplierId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PieceId)
                .ForeignKey("dbo.ref_Supplier", t => t.ref_SupplierId, cascadeDelete: true)
                .Index(t => t.ref_SupplierId);
            
            CreateTable(
                "dbo.ref_Supplier",
                c => new
                    {
                        ref_SupplierId = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.ref_SupplierId);
            
            CreateTable(
                "dbo.ref_ProductionArea",
                c => new
                    {
                        ref_ProductionAreaId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ref_ProductionAreaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Anomaly", "ref_ProductionAreaId", "dbo.ref_ProductionArea");
            DropForeignKey("dbo.Piece", "ref_SupplierId", "dbo.ref_Supplier");
            DropForeignKey("dbo.Anomaly", "PieceId", "dbo.Piece");
            DropForeignKey("dbo.HCQ", "ref_CQId", "dbo.ref_CQ");
            DropForeignKey("dbo.Expertise", "ExpertiseId", "dbo.TicketNC");
            DropForeignKey("dbo.TicketNC", "ref_UnitId", "dbo.ref_Unit");
            DropForeignKey("dbo.TicketNC", "ref_ProductTypeId", "dbo.ref_ProductType");
            DropForeignKey("dbo.TicketNC", "ref_ProductCodeId", "dbo.ref_ProductCode");
            DropForeignKey("dbo.TicketNC", "ref_PieceTypeId", "dbo.ref_PieceType");
            DropForeignKey("dbo.TicketNC", "ref_MachineId", "dbo.ref_Machine");
            DropForeignKey("dbo.TicketNC", "ref_CQId", "dbo.ref_CQ");
            DropForeignKey("dbo.TicketNC", "TicketNCId", "dbo.Anomaly");
            DropForeignKey("dbo.Expertise", "ref_VentilationId", "dbo.ref_Ventilation");
            DropForeignKey("dbo.Expertise", "ref_ImputationId", "dbo.ref_Imputation");
            DropForeignKey("dbo.Expertise", "ref_CQId", "dbo.ref_CQ");
            DropForeignKey("dbo.Expertise", "ref_CauseZEId", "dbo.ref_CauseZE");
            DropForeignKey("dbo.Expertise", "PafId", "dbo.Paf");
            DropForeignKey("dbo.Expertise", "NocoId", "dbo.Noco");
            DropForeignKey("dbo.HCQ", "HId", "dbo.H");
            DropForeignKey("dbo.H", "HId", "dbo.Anomaly");
            DropIndex("dbo.Piece", new[] { "ref_SupplierId" });
            DropIndex("dbo.ref_Machine", new[] { "ProductionAreaName" });
            DropIndex("dbo.TicketNC", new[] { "ref_CQId" });
            DropIndex("dbo.TicketNC", new[] { "ref_UnitId" });
            DropIndex("dbo.TicketNC", new[] { "ref_PieceTypeId" });
            DropIndex("dbo.TicketNC", new[] { "ref_ProductTypeId" });
            DropIndex("dbo.TicketNC", new[] { "ref_ProductCodeId" });
            DropIndex("dbo.TicketNC", new[] { "ref_MachineId" });
            DropIndex("dbo.TicketNC", new[] { "TicketNCId" });
            DropIndex("dbo.ref_Ventilation", new[] { "ProductionAreaName" });
            DropIndex("dbo.ref_Imputation", new[] { "ProductionAreaName" });
            DropIndex("dbo.ref_CauseZE", new[] { "ProductionAreaName" });
            DropIndex("dbo.Expertise", new[] { "ref_CQId" });
            DropIndex("dbo.Expertise", new[] { "NocoId" });
            DropIndex("dbo.Expertise", new[] { "PafId" });
            DropIndex("dbo.Expertise", new[] { "ref_ImputationId" });
            DropIndex("dbo.Expertise", new[] { "ref_VentilationId" });
            DropIndex("dbo.Expertise", new[] { "ref_CauseZEId" });
            DropIndex("dbo.Expertise", new[] { "ExpertiseId" });
            DropIndex("dbo.ref_CQ", new[] { "ProductionAreaName" });
            DropIndex("dbo.HCQ", new[] { "ref_CQId" });
            DropIndex("dbo.HCQ", new[] { "HId" });
            DropIndex("dbo.H", new[] { "HId" });
            DropIndex("dbo.Anomaly", new[] { "PieceId" });
            DropIndex("dbo.Anomaly", new[] { "ref_ProductionAreaId" });
            DropTable("dbo.ref_ProductionArea");
            DropTable("dbo.ref_Supplier");
            DropTable("dbo.Piece");
            DropTable("dbo.ref_Unit");
            DropTable("dbo.ref_ProductType");
            DropTable("dbo.ref_ProductCode");
            DropTable("dbo.ref_PieceType");
            DropTable("dbo.ref_Machine");
            DropTable("dbo.TicketNC");
            DropTable("dbo.ref_Ventilation");
            DropTable("dbo.ref_Imputation");
            DropTable("dbo.ref_CauseZE");
            DropTable("dbo.Paf");
            DropTable("dbo.Noco");
            DropTable("dbo.Expertise");
            DropTable("dbo.ref_CQ");
            DropTable("dbo.HCQ");
            DropTable("dbo.H");
            DropTable("dbo.Anomaly");
        }
    }
}
