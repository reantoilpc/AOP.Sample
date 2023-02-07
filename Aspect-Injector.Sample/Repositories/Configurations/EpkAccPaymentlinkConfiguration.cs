using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aspect_Injector.Sample.Repositories.Configurations
{
    public partial class EpkAccPaymentlinkConfiguration : IEntityTypeConfiguration<EpkAccPaymentlink>
    {
        public void Configure(EntityTypeBuilder<EpkAccPaymentlink> entity)
        {
            entity.HasKey(e => e.AccPaymentId);

            entity.ToTable("EPK_ACC_PAYMENTLINK");

            entity.HasIndex(e => new { e.EpkAccId, e.Status })
                .HasName("IX_EPK_ACC_PAYMENTLINK");

            entity.Property(e => e.AccPaymentId).HasColumnName("ACC_PAYMENT_ID");

            entity.Property(e => e.CarrierId1)
                .HasColumnName("CARRIER_ID1")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.CarrierId2)
                .HasColumnName("CARRIER_ID2")
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.CarrierType)
                .HasColumnName("CARRIER_TYPE")
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.EffectiveTime)
                .HasColumnName("EFFECTIVE_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.EpkAccId)
                .HasColumnName("EPK_ACC_ID")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.FetcAccount)
                .HasColumnName("FETC_ACCOUNT")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.Npoban)
                .HasColumnName("NPOBAN")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");

            entity.Property(e => e.PaymentMasterId).HasColumnName("PAYMENT_MASTER_ID");

            entity.Property(e => e.ReceiptEin)
                .HasColumnName("RECEIPT_EIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReceiptType)
                .HasColumnName("RECEIPT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Status)
                .HasColumnName("STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EpkAccPaymentlink> entity);
    }
}
