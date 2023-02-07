using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aspect_Injector.Sample.Repositories.Configurations
{
    public partial class EpkAccAccountConfiguration : IEntityTypeConfiguration<EpkAccAccount>
    {
        public void Configure(EntityTypeBuilder<EpkAccAccount> entity)
        {
            entity.HasKey(e => e.EpkAccId);

            entity.ToTable("EPK_ACC_ACCOUNT");

            entity.Property(e => e.EpkAccId)
                .HasColumnName("EPK_ACC_ID")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.AccNo)
                .IsRequired()
                .HasColumnName("ACC_NO")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.AccStatus)
                .HasColumnName("ACC_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.AccessPaymentStatus)
                .HasColumnName("ACCESS_PAYMENT_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.AccessStatus)
                .HasColumnName("ACCESS_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.AclMasterId).HasColumnName("ACL_MASTER_ID");

            entity.Property(e => e.CarIdentity)
                .HasColumnName("CAR_IDENTITY")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasColumnName("EMAIL")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EpcId)
                .HasColumnName("EPC_ID")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.EpcidCrypt)
                .HasColumnName("EPCID_CRYPT")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.EpkStatus)
                .IsRequired()
                .HasColumnName("EPK_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.EtagModel)
                .HasColumnName("ETAG_MODEL")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.EtagStatus)
                .HasColumnName("ETAG_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.IdNo)
                .IsRequired()
                .HasColumnName("ID_NO")
                .HasMaxLength(16)
                .IsUnicode(false);

            entity.Property(e => e.InitialTime)
                .HasColumnName("INITIAL _TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.LastSyncTime)
                .HasColumnName("LAST_SYNC_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.Lpr)
                .IsRequired()
                .HasColumnName("LPR")
                .HasMaxLength(16);

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .HasMaxLength(128);

            entity.Property(e => e.NvdisCategory)
                .HasColumnName("NVDIS_CATEGORY")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasColumnName("PHONE_NUMBER")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.ReceiptEin)
                .HasColumnName("RECEIPT_EIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ServiceStatus)
                .HasColumnName("SERVICE_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.Tid)
                .HasColumnName("TID")
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.UtaggoUuid)
                .HasColumnName("UTAGGO_UUID")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.VehicleStatus)
                .HasColumnName("VEHICLE_STATUS")
                .HasMaxLength(5)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EpkAccAccount> entity);
    }
}
