using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aspect_Injector.Sample.Repositories.Configurations
{
    public partial class BmsProServiceConfiguration : IEntityTypeConfiguration<BmsProService>
    {
        public void Configure(EntityTypeBuilder<BmsProService> entity)
        {
            entity.HasKey(e => e.ServiceId);

            entity.ToTable("BMS_PRO_SERVICE");

            entity.Property(e => e.ServiceId).HasColumnName("SERVICE_ID");

            entity.Property(e => e.GroupId)
                .HasColumnName("GROUP_ID")
                .HasMaxLength(16);

            entity.Property(e => e.GroupType).HasColumnName("GROUP_TYPE");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("money");

            entity.Property(e => e.PricingModel).HasColumnName("PRICING_MODEL");

            entity.Property(e => e.PricingQty)
                .HasColumnName("PRICING_QTY")
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.PricingUnit).HasColumnName("PRICING_UNIT");

            entity.Property(e => e.ServiceDesc)
                .HasColumnName("SERVICE_DESC")
                .HasMaxLength(256);

            entity.Property(e => e.ServiceName)
                .HasColumnName("SERVICE_NAME")
                .HasMaxLength(256);

            entity.Property(e => e.ServiceParentId).HasColumnName("SERVICE_PARENT_ID");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<BmsProService> entity);
    }
}
