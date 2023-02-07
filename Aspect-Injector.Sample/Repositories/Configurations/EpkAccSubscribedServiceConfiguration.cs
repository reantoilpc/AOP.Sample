using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aspect_Injector.Sample.Repositories.Configurations
{
    public partial class EpkAccSubscribedServiceConfiguration : IEntityTypeConfiguration<EpkAccSubscribedService>
    {
        public void Configure(EntityTypeBuilder<EpkAccSubscribedService> entity)
        {
            entity.HasKey(e => e.Sn);

            entity.ToTable("EPK_ACC_SUBSCRIBED_SERVICE");

            entity.HasIndex(e => new { e.EpkAccId, e.ProviderServiceId })
                .HasName("Idx_Subscribe_AccId_ServiceId");

            entity.Property(e => e.Sn).HasColumnName("SN");

            entity.Property(e => e.AccPaymentId).HasColumnName("ACC_PAYMENT_ID");

            entity.Property(e => e.AccessStartDate)
                .HasColumnName("ACCESS_START_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.AclMasterId).HasColumnName("ACL_MASTER_ID");

            entity.Property(e => e.ConsumerId).HasColumnName("CONSUMER_ID");

            entity.Property(e => e.ConsumerServiceId).HasColumnName("CONSUMER_SERVICE_ID");

            entity.Property(e => e.ContractId).HasColumnName("CONTRACT_ID");

            entity.Property(e => e.EffectiveTime)
                .HasColumnName("EFFECTIVE_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.Ein)
                .HasColumnName("EIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EpkAccId)
                .IsRequired()
                .HasColumnName("EPK_ACC_ID")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.InitialFlag)
                .HasColumnName("INITIAL_FLAG")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.IsPayment).HasColumnName("IS_PAYMENT");

            entity.Property(e => e.LastPaymentDate)
                .HasColumnName("LAST_PAYMENT_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.NextPaymentDate)
                .HasColumnName("NEXT_PAYMENT_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.PaymentAmount).HasColumnName("PAYMENT_AMOUNT");

            entity.Property(e => e.PaymentDate).HasColumnName("PAYMENT_DATE");

            entity.Property(e => e.PaymentMethodId).HasColumnName("PAYMENT_METHOD_ID");

            entity.Property(e => e.PaymentPeriod).HasColumnName("PAYMENT_PERIOD");

            entity.Property(e => e.PaymentStatus)
                .HasColumnName("PAYMENT_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.PreStatus)
                .HasColumnName("PRE_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.PreStatusDate)
                .HasColumnName("PRE_STATUS_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.ProviderServiceId).HasColumnName("PROVIDER_SERVICE_ID");

            entity.Property(e => e.ReceiptId).HasColumnName("RECEIPT_ID");

            entity.Property(e => e.RentmodifySn).HasColumnName("RENTMODIFY_SN");

            entity.Property(e => e.RentreqSn)
                .HasColumnName("RENTREQ_SN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ServiceItem)
                .HasColumnName("SERVICE_ITEM")
                .HasDefaultValueSql("((0))");

            entity.Property(e => e.ServiceStatus)
                .HasColumnName("SERVICE_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.StartDate)
                .HasColumnName("START_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.TerminatedDate)
                .HasColumnName("TERMINATED_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.TimeIntervalE)
                .HasColumnName("TIME_INTERVAL_E")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.TimeIntervalS)
                .HasColumnName("TIME_INTERVAL_S")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.UploadTime)
                .HasColumnName("UPLOAD_TIME")
                .HasColumnType("datetime");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EpkAccSubscribedService> entity);
    }
}
