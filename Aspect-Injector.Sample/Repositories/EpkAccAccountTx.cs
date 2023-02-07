#nullable disable
using System;

namespace Aspect_Injector.Sample.Repositories
{
    public partial class EpkAccAccountTx
    {
        public string EpkAccId { get; set; }
        public DateTime? ArriveTime { get; set; }
        public string ArriveSeq { get; set; }
        public string ArriveMac { get; set; }
        public DateTime? DepartTime { get; set; }
        public string DepartSeq { get; set; }
        public string DepartMac { get; set; }
        public string EpcId { get; set; }
        public string Lpr { get; set; }
        public string EodSeq { get; set; }
        public DateTime EodTime { get; set; }
        public DateTime FetcEodTime { get; set; }
        public int ServiceId { get; set; }
        public string ChargeType { get; set; }
        public int? Vender { get; set; }
        public string ChannelCode { get; set; }
        public string Field { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal? Price { get; set; }
        public string VehicleKind { get; set; }
        public string Block { get; set; }
        public string Road { get; set; }
        public string ConnectMode { get; set; }
        public string Sam { get; set; }
        public DateTime? DebtTime { get; set; }
        public string DebtResult { get; set; }
        public DateTime? EstTime { get; set; }
        public string Veriftied { get; set; }
        public string FailReasonCode { get; set; }
        public int? FailReasonType { get; set; }
        public DateTime? BillingDate { get; set; }
        public string BillEod { get; set; }
        public int? BillBankId { get; set; }
        public string BankAccId { get; set; }
        public long? RefundTxId { get; set; }
        public DateTime? AccessStartDate { get; set; }
        public DateTime? BkCashflow { get; set; }
        public DateTime? VdCashflow { get; set; }
        public string RentreqSn { get; set; }
        public long? ReceiptSn { get; set; }
        public long? AccPaymentId { get; set; }
        public DateTime? RecBms { get; set; }
        public DateTime? RespCity { get; set; }
        public decimal? OriPrice { get; set; }
        public DateTime? WriteoffDate { get; set; }
        public string WriteoffStatus { get; set; }
        public string ReceiptEin { get; set; }
        public DateTime? ExpectedReceiptDate { get; set; }
        public string DebtType { get; set; }
        public int ChargeCount { get; set; }
        public string ChargeStatus { get; set; }
        public DateTime? NextChargeDate { get; set; }
        public string CardTransSn { get; set; }
        public DateTime? CardTransDate { get; set; }
        public string StoreId { get; set; }
        public string DebtReason { get; set; }
        public decimal? PrimitivePrice { get; set; }
        public decimal? EvChargePrice { get; set; }
        public DateTime? FirstBillingDate { get; set; }
        public DateTime? PaymentTime { get; set; }
    }
}