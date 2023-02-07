#nullable disable
using System;

namespace Aspect_Injector.Sample.Repositories
{
    public partial class EpkAccPaymentlink
    {
        public long AccPaymentId { get; set; }
        public string EpkAccId { get; set; }
        public int? PaymentId { get; set; }
        public string FetcAccount { get; set; }
        public string Status { get; set; }
        public int? PaymentMasterId { get; set; }
        public string Npoban { get; set; }
        public string CarrierType { get; set; }
        public string CarrierId1 { get; set; }
        public string CarrierId2 { get; set; }
        public DateTime? EffectiveTime { get; set; }
        public string ReceiptEin { get; set; }
        public string ReceiptType { get; set; }
    }
}