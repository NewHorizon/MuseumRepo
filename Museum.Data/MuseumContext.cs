using Museum.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Data
{
    /// <summary>
    /// Контекст бд музея
    /// </summary>
    public class MuseumContext : DbContext
    {
        private const string contextName = "MuseumContext";
        public static string ContextName { get { return contextName; } }  

        static MuseumContext()
        {
            //Database.SetInitializer(new BlocknotDatabaseInitializer());
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MuseumContext, Museum.Migrations.Configuration>());
        }

        public MuseumContext()
            : base(ContextName)
        {
            // Disable proxy creation and lazy loading; not wanted in this service context.
            Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Table names match entity names by default (don't pluralize)
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new CardConfiguration());
        }

        #region DbSetes
        public DbSet<Card> Cards { get; set; }
        public DbSet<Dating> Datings { get; set; }
        public DbSet<Doer> Doers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MedicineSection> MedicineSections { get; set; }
        public DbSet<MuseumName> MuseumNames { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<SubjectTitle> SubjectTitles { get; set; }
             
        #endregion
    }

    #region Конфигурации таблиц

    /// <summary>
    /// Конфигурация таблицы карт научного описания
    /// </summary>
    public class CardConfiguration : EntityTypeConfiguration<Card>
    {
        public CardConfiguration()
        {
            HasRequired(c => c.MuseumName)
                .WithMany()
                .HasForeignKey(c => c.MuseumNameId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Dating)
                .WithMany()
                .HasForeignKey(c => c.DatingId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Doer)
                .WithMany()
                .HasForeignKey(c => c.DoerId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.SubjectTitle)
                .WithMany()
                .HasForeignKey(c => c.SubjectTitleId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.MedicineSection)
                .WithMany()
                .HasForeignKey(c => c.MedicineSectionId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.Location)
                .WithMany()
                .HasForeignKey(c => c.LocationId)
                .WillCascadeOnDelete(false);
            
            HasRequired(c => c.Material)
                .WithMany()
                .HasForeignKey(c => c.MaterialId)
                .WillCascadeOnDelete(false);

            HasRequired(c => c.State)
                .WithMany()
                .HasForeignKey(c => c.StateId)
                .WillCascadeOnDelete(false);
        }
    }    

    #endregion
}
