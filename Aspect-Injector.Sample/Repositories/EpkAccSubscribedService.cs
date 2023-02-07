#nullable disable
using System;

namespace Aspect_Injector.Sample.Repositories
{
    public partial class EpkAccSubscribedService
    {
        public long Sn { get; set; }
        public string EpkAccId { get; set; }
        public int ProviderServiceId { get; set; }
        public string ServiceStatus { get; set; }
        public DateTime? EffectiveTime { get; set; }
        public int? AclMasterId { get; set; }
        public int PaymentMethodId { get; set; }
        public int ConsumerServiceId { get; set; }
        public int ContractId { get; set; }
        public int ConsumerId { get; set; }
        public DateTime? UploadTime { get; set; }
        public int? IsPayment { get; set; }
        public string PaymentStatus { get; set; }
        public int? PaymentPeriod { get; set; }
        public int? PaymentAmount { get; set; }
        public int? PaymentDate { get; set; }
        public DateTime? NextPaymentDate { get; set; }
        public string TimeIntervalS { get; set; }
        public string TimeIntervalE { get; set; }
        public DateTime? TerminatedDate { get; set; }
        public int? ReceiptId { get; set; }
        public string Ein { get; set; }
        public string RentreqSn { get; set; }
        public DateTime? AccessStartDate { get; set; }
        public DateTime? StartDate { get; set; }
        public string InitialFlag { get; set; }
        public DateTime? LastPaymentDate { get; set; }
        public long? RentmodifySn { get; set; }
        public string PreStatus { get; set; }
        public DateTime? PreStatusDate { get; set; }
        public long? AccPaymentId { get; set; }
        public int? ServiceItem { get; set; }
    }
}