using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aspect_Injector.Sample.Repositories.Configurations
{
    public partial class EpkProPaymentConfiguration : IEntityTypeConfiguration<EpkProPayment>
    {
        public void Configure(EntityTypeBuilder<EpkProPayment> entity)
        {
            entity.HasKey(e => e.PaymentId)
                .HasName("PK_EPK_PRO_PAYMENT_1");

            entity.ToTable("EPK_PRO_PAYMENT");

            entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");

            entity.Property(e => e.PaymentDesc)
                .HasColumnName("PAYMENT_DESC")
                .HasMaxLength(50);

            entity.Property(e => e.PaymentName)
                .HasColumnName("PAYMENT_NAME")
                .HasMaxLength(50);

            entity.Property(e => e.PaymentType)
                .HasColumnName("PAYMENT_TYPE")
                .HasMaxLength(20)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EpkProPayment> entity);
    }
}
