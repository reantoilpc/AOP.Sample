using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Aspect_Injector.Sample.Repositories.Configurations
{
    public partial class EpkAccAccountTxConfiguration : IEntityTypeConfiguration<EpkAccAccountTx>
    {
        public void Configure(EntityTypeBuilder<EpkAccAccountTx> entity)
        {
            entity.HasKey(e => new { e.FetcEodTime, e.EodSeq });

            entity.ToTable("EPK_ACC_ACCOUNT_TX");

            entity.HasIndex(e => new { e.FetcEodTime, e.CardTransDate })
                .HasName("EPK_ACC_ACCOUNT_TX_IDX08_CARD_TRANS_DATE");

            entity.HasIndex(e => new { e.FetcEodTime, e.ServiceId, e.ArriveTime })
                .HasName("Idx_ACCTX_EODtime_Service_Arrive");

            entity.Property(e => e.FetcEodTime)
                .HasColumnName("FETC_EOD_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.EodSeq)
                .HasColumnName("EOD_SEQ")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.AccPaymentId).HasColumnName("ACC_PAYMENT_ID");

            entity.Property(e => e.AccessStartDate)
                .HasColumnName("ACCESS_START_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.ArriveMac)
                .HasColumnName("ARRIVE_MAC")
                .HasMaxLength(96)
                .IsUnicode(false);

            entity.Property(e => e.ArriveSeq)
                .HasColumnName("ARRIVE_SEQ")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.ArriveTime)
                .HasColumnName("ARRIVE_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.BankAccId)
                .HasColumnName("BANK_ACC_ID")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BillBankId).HasColumnName("BILL_BANK_ID");

            entity.Property(e => e.BillEod)
                .HasColumnName("BILL_EOD")
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BillingDate)
                .HasColumnName("BILLING_DATE")
                .HasColumnType("date");

            entity.Property(e => e.BkCashflow)
                .HasColumnName("BK_CASHFLOW")
                .HasColumnType("datetime");

            entity.Property(e => e.Block)
                .HasColumnName("BLOCK")
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.CardTransDate)
                .HasColumnName("CARD_TRANS_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.CardTransSn)
                .HasColumnName("CARD_TRANS_SN")
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.ChannelCode)
                .HasColumnName("CHANNEL_CODE")
                .HasMaxLength(16);

            entity.Property(e => e.ChargeCount).HasColumnName("CHARGE_COUNT");

            entity.Property(e => e.ChargeStatus)
                .HasColumnName("CHARGE_STATUS")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ChargeType)
                .HasColumnName("CHARGE_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.ConnectMode)
                .HasColumnName("CONNECT_MODE")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.DebtReason)
                .HasColumnName("DEBT_REASON")
                .HasMaxLength(200);

            entity.Property(e => e.DebtResult)
                .HasColumnName("DEBT_RESULT")
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.DebtTime)
                .HasColumnName("DEBT_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.DebtType)
                .HasColumnName("DEBT_TYPE")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.DepartMac)
                .HasColumnName("DEPART_MAC")
                .HasMaxLength(96)
                .IsUnicode(false);

            entity.Property(e => e.DepartSeq)
                .HasColumnName("DEPART_SEQ")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.DepartTime)
                .HasColumnName("DEPART_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.DueDate)
                .HasColumnName("DUE_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.EodTime)
                .HasColumnName("EOD_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.EpcId)
                .IsRequired()
                .HasColumnName("EPC_ID")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.EpkAccId)
                .IsRequired()
                .HasColumnName("EPK_ACC_ID")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.EstTime)
                .HasColumnName("EST_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.EvChargePrice)
                .HasColumnName("EV_CHARGE_PRICE")
                .HasColumnType("money");

            entity.Property(e => e.ExpectedReceiptDate)
                .HasColumnName("EXPECTED_RECEIPT_DATE")
                .HasColumnType("date");

            entity.Property(e => e.FailReasonCode)
                .HasColumnName("FAIL_REASON_CODE")
                .HasMaxLength(16);

            entity.Property(e => e.FailReasonType).HasColumnName("FAIL_REASON_TYPE");

            entity.Property(e => e.Field)
                .HasColumnName("FIELD")
                .HasMaxLength(10);

            entity.Property(e => e.FirstBillingDate)
                .HasColumnName("FIRST_BILLING_DATE")
                .HasColumnType("date");

            entity.Property(e => e.Lpr)
                .IsRequired()
                .HasColumnName("LPR")
                .HasMaxLength(16);

            entity.Property(e => e.NextChargeDate)
                .HasColumnName("NEXT_CHARGE_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.OriPrice)
                .HasColumnName("ORI_PRICE")
                .HasColumnType("money");

            entity.Property(e => e.PaymentTime)
                .HasColumnName("PAYMENT_TIME")
                .HasColumnType("datetime");

            entity.Property(e => e.Price)
                .HasColumnName("PRICE")
                .HasColumnType("money");

            entity.Property(e => e.PrimitivePrice)
                .HasColumnName("PRIMITIVE_PRICE")
                .HasColumnType("money");

            entity.Property(e => e.RecBms)
                .HasColumnName("REC_BMS")
                .HasColumnType("datetime");

            entity.Property(e => e.ReceiptEin)
                .HasColumnName("RECEIPT_EIN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ReceiptSn).HasColumnName("RECEIPT_SN");

            entity.Property(e => e.RefundTxId).HasColumnName("REFUND_TX_ID");

            entity.Property(e => e.RentreqSn)
                .HasColumnName("RENTREQ_SN")
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RespCity)
                .HasColumnName("RESP_CITY")
                .HasColumnType("datetime");

            entity.Property(e => e.Road)
                .HasColumnName("ROAD")
                .HasMaxLength(50);

            entity.Property(e => e.Sam)
                .HasColumnName("SAM")
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.ServiceId).HasColumnName("SERVICE_ID");

            entity.Property(e => e.StoreId)
                .HasColumnName("STORE_ID")
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.VdCashflow)
                .HasColumnName("VD_CASHFLOW")
                .HasColumnType("datetime");

            entity.Property(e => e.VehicleKind)
                .HasColumnName("VEHICLE_KIND")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.Vender).HasColumnName("VENDER");

            entity.Property(e => e.Veriftied)
                .HasColumnName("VERIFTIED")
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.WriteoffDate)
                .HasColumnName("WRITEOFF_DATE")
                .HasColumnType("datetime");

            entity.Property(e => e.WriteoffStatus)
                .HasColumnName("WRITEOFF_STATUS")
                .HasMaxLength(2)
                .IsUnicode(false);

            OnConfigurePartial(entity);
        }

        partial void OnConfigurePartial(EntityTypeBuilder<EpkAccAccountTx> entity);
    }
}
