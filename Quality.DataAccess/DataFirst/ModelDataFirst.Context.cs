﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quality.DataAccess.DataFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QualityEntities : DbContext
    {
        public QualityEntities()
            : base("name=QualityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Anomaly> Anomaly { get; set; }
        public virtual DbSet<Expertise> Expertise { get; set; }
        public virtual DbSet<H> H { get; set; }
        public virtual DbSet<HCQ> HCQ { get; set; }
        public virtual DbSet<NoCo> NoCo { get; set; }
        public virtual DbSet<PAF> PAF { get; set; }
        public virtual DbSet<Piece> Piece { get; set; }
        public virtual DbSet<ref_CauseZE> ref_CauseZE { get; set; }
        public virtual DbSet<ref_CQ> ref_CQ { get; set; }
        public virtual DbSet<ref_Machine> ref_Machine { get; set; }
        public virtual DbSet<ref_ProductCode> ref_ProductCode { get; set; }
        public virtual DbSet<ref_ProductionArea> ref_ProductionArea { get; set; }
        public virtual DbSet<ref_ProductType> ref_ProductType { get; set; }
        public virtual DbSet<ref_Supplier> ref_Supplier { get; set; }
        public virtual DbSet<ref_TypePiece> ref_TypePiece { get; set; }
        public virtual DbSet<ref_Unit> ref_Unit { get; set; }
        public virtual DbSet<TicketNC> TicketNC { get; set; }
    }
}
