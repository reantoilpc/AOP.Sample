using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aspect_Injector.Sample.Repositories.Configurations
{
    public partial class EpkAccTraTxConfiguration : IEntityTypeConfiguration<EpkAccTraTx>
    {
        public void Configure(EntityTypeBuilder<EpkAccTraTx> entity)
        {
            entity.HasKey(e => new { e.EpcId, e.TransactionTime, e.TransactionCode });

            entity.ToTable("EPK_ACC_TRA_TX");

            entity.HasIndex(e => new { e.TransactionTime, e.EpkAccId, e.ServiceId })
                .HasName("Idx_TraTx_transactiontime_epkaccid_serviceId_fq");

            entity.Property(e => e.EpcId)
                .HasColumnName("EPC_ID")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.TransactionTime)
                .HasColumnName("TRANSACTION_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.TransactionCode)
                .HasColumnName("TRANSACTION_CODE")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.AccPaymentId).HasColumnName("ACC_PAYMENT_ID");

            entity.Property(e => e.Block)
                .HasColumnName("BLOCK")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.BuyerEin)
                .HasColumnName("BUYER_EIN")
                .HasMaxLength(20)
                .IsUnicode(false);

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

            entity.Property(e => e.ChannelCode)
                .HasColumnName("CHANNEL_CODE")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasColumnName("CITY")
                .HasMaxLength(16);

            entity.Property(e => e.EpkAccId)
                .HasColumnName("EPK_ACC_ID")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.ErrorMsg)
                .HasColumnName("ERROR_MSG")
                .HasMaxLength(20);

            entity.Property(e => e.ErrorMsgCode)
                .HasColumnName("ERROR_MSG_CODE")
                .HasMaxLength(16);

            entity.Property(e => e.ErrorMsgType).HasColumnName("ERROR_MSG_TYPE");

            entity.Property(e => e.Issendsms)
                .HasColumnName("ISSENDSMS")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.LoveCode)
                .HasColumnName("LOVE_CODE")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Lpr)
                .IsRequired()
                .HasColumnName("LPR")
                .HasMaxLength(16);

            entity.Property(e => e.Mac)
                .HasColumnName("MAC")
                .HasMaxLength(96)
                .IsUnicode(false);

            entity.Property(e => e.Npoban)
                .HasColumnName("NPOBAN")
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.OriPrice)
                .HasColumnName("ORI_PRICE")
                .HasColumnType("money");

            entity.Property(e => e.ParkinglotOrderId)
                .HasColumnName("PARKINGLOT_ORDER_ID")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("money");

            entity.Property(e => e.Road)
                .HasColumnName("ROAD")
                .HasMaxLength(50);

            entity.Property(e => e.Sam)
                .HasColumnName("SAM")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Seq).HasColumnName("SEQ");

            entity.Property(e => e.ServiceId).HasColumnName("SERVICE_ID");

            entity.Property(e => e.TraTxId)
                .HasColumnName("TRA_TX_ID")
                .ValueGeneratedOnAdd();

            entity.Property(e => e.TransactionSeq)
                .HasColumnName("TRANSACTION_SEQ")
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TransactionType).HasColumnName("TRANSACTION_TYPE");

            entity.Property(e => e.Vender).HasColumnName("VENDER");

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EpkAccTraTx> entity);
    }
}
