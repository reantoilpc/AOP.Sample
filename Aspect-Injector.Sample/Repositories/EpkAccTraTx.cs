#nullable disable
using System;

namespace Aspect_Injector.Sample.Repositories
{
    public partial class EpkAccTraTx
    {
        public long TraTxId { get; set; }
        public string EpkAccId { get; set; }
        public DateTime TransactionTime { get; set; }
        public string TransactionSeq { get; set; }
        public string Mac { get; set; }
        public string EpcId { get; set; }
        public string Lpr { get; set; }
        public int ServiceId { get; set; }
        public int? TransactionType { get; set; }
        public string TransactionCode { get; set; }
        public int? Vender { get; set; }
        public string ChannelCode { get; set; }
        public string Block { get; set; }
        public string Road { get; set; }
        public string Issendsms { get; set; }
        public decimal? Price { get; set; }
        public int? ErrorMsgType { get; set; }
        public string ErrorMsgCode { get; set; }
        public string City { get; set; }
        public string Sam { get; set; }
        public string ErrorMsg { get; set; }
        public decimal? OriPrice { get; set; }
        public string ParkinglotOrderId { get; set; }
        public string BuyerEin { get; set; }
        public string CarrierType { get; set; }
        public string CarrierId1 { get; set; }
        public string CarrierId2 { get; set; }
        public string Npoban { get; set; }
        public string LoveCode { get; set; }
        public long? AccPaymentId { get; set; }
        public int? Seq { get; set; }
    }
}