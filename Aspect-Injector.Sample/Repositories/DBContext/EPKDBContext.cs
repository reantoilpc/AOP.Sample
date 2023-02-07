#nullable disable

using Aspect_Injector.Sample.Repositories.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Aspect_Injector.Sample.Repositories.DBContext
{
    public partial class EPKDBContext : DbContext
    {
        public EPKDBContext()
        {
        }

        public EPKDBContext(DbContextOptions<EPKDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BmsProService> BmsProServices { get; set; }
        public virtual DbSet<EpkAccAccount> EpkAccAccounts { get; set; }
        public virtual DbSet<EpkAccAccountTx> EpkAccAccountTxes { get; set; }
        public virtual DbSet<EpkAccPaymentlink> EpkAccPaymentlinks { get; set; }
        public virtual DbSet<EpkAccSubscribedService> EpkAccSubscribedServices { get; set; }
        public virtual DbSet<EpkAccTraTx> EpkAccTraTxes { get; set; }
        public virtual DbSet<EpkExcWhitelist> EpkExcWhitelists { get; set; }
        public virtual DbSet<EpkProPayment> EpkProPayments { get; set; }
        public virtual DbSet<EpkProProviderService> EpkProProviderServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BmsProServiceConfiguration());
            modelBuilder.ApplyConfiguration(new EpkAccAccountConfiguration());
            modelBuilder.ApplyConfiguration(new EpkAccAccountTxConfiguration());
            modelBuilder.ApplyConfiguration(new EpkAccPaymentlinkConfiguration());
            modelBuilder.ApplyConfiguration(new EpkAccSubscribedServiceConfiguration());
            modelBuilder.ApplyConfiguration(new EpkAccTraTxConfiguration());
            modelBuilder.ApplyConfiguration(new EpkExcWhitelistConfiguration());
            modelBuilder.ApplyConfiguration(new EpkProPaymentConfiguration());
            modelBuilder.ApplyConfiguration(new EpkProProviderServiceConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
