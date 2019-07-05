using System.Data.Entity;

namespace Quality.DataAccess
{
    public class QualityContext : DbContext
    {
        public QualityContext() : base("QualityConnection")
        {
         //   Database.SetInitializer(new MigrateDatabaseToLatestVersion<QualityContext, Migrations.Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adds configurations for Student from separate class
            //modelBuilder.Configurations.Add(new StudentConfigurations());

            //modelBuilder.Entity<Teacher>()
            //    .ToTable("TeacherInfo");

            //modelBuilder.Entity<Teacher>()
            //    .MapToStoredProcedures();
        }

        public DbSet<Anomaly> AnomalyCollection { get; set; }
        public DbSet<Expertise> ExpertiseCollection { get; set; }
        public DbSet<H> HCollection { get; set; }
        public DbSet<HCQ> HCQCollection { get; set; }
        public DbSet<Noco> NocoCollection { get; set; }
        public DbSet<Paf> PafCollection { get; set; }
        public DbSet<Piece> PieceCollection { get; set; }
        public DbSet<ref_CauseZE> ref_CauseZECollection { get; set; }
        public DbSet<ref_CQ> ref_CQCollection { get; set; }
        public DbSet<ref_Imputation> ref_ImputationCollection { get; set; }
        public DbSet<ref_Machine> ref_MachineCollection { get; set; }
        public DbSet<ref_PieceType> ref_PieceTypeCollection { get; set; }
        public DbSet<ref_ProductCode> ref_ProductCodeCollection { get; set; }
        public DbSet<ref_ProductionArea> ref_ProductionAreaCollection { get; set; }
        public DbSet<ref_ProductType> ref_ProductTypeCollection { get; set; }
        public DbSet<ref_Unit> ref_UnitCollection { get; set; }
        public DbSet<ref_Ventilation> ref_VentilationCollection { get; set; }
        public DbSet<Supplier> SupplierCollection { get; set; }
        public DbSet<TicketNC> TicketNCCollection { get; set; }
    }
}
