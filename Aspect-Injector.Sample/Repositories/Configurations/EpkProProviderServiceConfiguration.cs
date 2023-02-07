using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aspect_Injector.Sample.Repositories.Configurations
{
    public partial class EpkProProviderServiceConfiguration : IEntityTypeConfiguration<EpkProProviderService>
    {
        public void Configure(EntityTypeBuilder<EpkProProviderService> entity)
        {
            entity.HasKey(e => e.ProviderServiceId);

            entity.ToTable("EPK_PRO_PROVIDER_SERVICE");

            entity.Property(e => e.ProviderServiceId).HasColumnName("PROVIDER_SERVICE_ID");

            entity.Property(e => e.ActiveTime)
                .HasColumnName("ACTIVE_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.ContractId).HasColumnName("CONTRACT_ID");

            entity.Property(e => e.FilterDay)
                .HasColumnName("FILTER_DAY")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.FilterWriteoffCount)
                .HasColumnName("FILTER_WRITEOFF_COUNT")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.InactiveTime)
                .HasColumnName("INACTIVE_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.OpenFilter)
                .HasColumnName("OPEN_FILTER")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("money");

            entity.Property(e => e.PricingModel).HasColumnName("PRICING_MODEL");

            entity.Property(e => e.PricingQty)
                .HasColumnName("PRICING_QTY")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.PricingUnit).HasColumnName("PRICING_UNIT");

            entity.Property(e => e.ProviderId).HasColumnName("PROVIDER_ID");

            entity.Property(e => e.ProviderServiceName)
                .HasColumnName("PROVIDER_SERVICE_NAME")
                .HasMaxLength(50);

            entity.Property(e => e.RoamingCode)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.SaId).HasColumnName("SA_ID");

            entity.Property(e => e.ServiceId).HasColumnName("SERVICE_ID");

            entity.Property(e => e.Siteinfocode)
                .HasColumnName("SITEINFOCODE")
                .HasMaxLength(60);

            entity.Property(e => e.Status)
                .IsRequired()
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .HasDefaultValueSql("('1')");

            entity.Property(e => e.SubscribedFlag).HasColumnName("SUBSCRIBED_FLAG");

            entity.Property(e => e.UseByCampaign)
                .IsRequired()
                .HasColumnName("USE_BY_CAMPAIGN")
                .HasMaxLength(1)
                .HasDefaultValueSql("('1')");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EpkProProviderService> entity);
    }
}
