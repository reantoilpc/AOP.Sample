using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aspect_Injector.Sample.Repositories.Configurations
{
    public partial class EpkExcWhitelistConfiguration : IEntityTypeConfiguration<EpkExcWhitelist>
    {
        public void Configure(EntityTypeBuilder<EpkExcWhitelist> entity)
        {
            entity.HasKey(e => new { e.Sn, e.UploadDate });

            entity.ToTable("EPK_EXC_WHITELIST");

            entity.HasIndex(e => e.UploadDate);

            entity.HasIndex(e => new { e.Version, e.ProviderServiceId, e.UploadDate, e.Isfull })
                .HasName("Idx_WHITELIST_Update_ServiceID");

            entity.Property(e => e.Sn)
                .HasColumnName("SN")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.UploadDate)
                .HasColumnName("UPLOAD_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.AccPaymentId).HasColumnName("ACC_PAYMENT_ID");

            entity.Property(e => e.AccStatus)
                .HasColumnName("ACC_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ArriveTime)
                .HasColumnName("ARRIVE_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.BankAccId)
                .HasColumnName("BANK_ACC_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CarIdentity)
                .HasColumnName("CAR_IDENTITY")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ChannelCode)
                .HasColumnName("CHANNEL_CODE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.ChargeType)
                .IsRequired()
                .HasColumnName("CHARGE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Ein)
                .HasColumnName("EIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Epcid)
                .IsRequired()
                .HasColumnName("EPCID")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.EpcidCrypt)
                .HasColumnName("EPCID_CRYPT")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.EpkAccId)
                .IsRequired()
                .HasColumnName("EPK_ACC_ID")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.EtagModel)
                .HasColumnName("ETAG_MODEL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EtagStatus)
                .HasColumnName("ETAG_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ExpireTime)
                .HasColumnName("EXPIRE_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.FileId)
                .IsRequired()
                .HasColumnName("FILE_ID")
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.Function)
                .HasColumnName("FUNCTION")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Indentify)
                .HasColumnName("INDENTIFY")
                .HasMaxLength(10);

            entity.Property(e => e.Isfull)
                .HasColumnName("ISFULL")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Lpr)
                .IsRequired()
                .HasColumnName("LPR")
                .HasMaxLength(10);

            entity.Property(e => e.PaymentId).HasColumnName("PAYMENT_ID");

            entity.Property(e => e.ProviderServiceId).HasColumnName("PROVIDER_SERVICE_ID");

            entity.Property(e => e.ReceiptData)
                .HasColumnName("RECEIPT_DATA")
                .HasMaxLength(9)
                .IsUnicode(false);

            entity.Property(e => e.ServiceItem).HasColumnName("SERVICE_ITEM");

            entity.Property(e => e.ServiceStatus)
                .HasColumnName("SERVICE_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.ServiceType).HasColumnName("SERVICE_TYPE");

            entity.Property(e => e.SubscribedServiceId).HasColumnName("SUBSCRIBED_SERVICE_ID");

            entity.Property(e => e.Tid)
                .IsRequired()
                .HasColumnName("TID")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.TimeIntervalE)
                .HasColumnName("TIME_INTERVAL_E")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.TimeIntervalS)
                .HasColumnName("TIME_INTERVAL_S")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.VehicleStatus)
                .HasColumnName("VEHICLE_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.VenderCode)
                .HasColumnName("VENDER_CODE")
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Version).HasColumnName("VERSION");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EpkExcWhitelist> entity);
    }
}
