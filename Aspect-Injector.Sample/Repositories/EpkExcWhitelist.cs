#nullable disable
using System;

namespace Aspect_Injector.Sample.Repositories
{
    public partial class EpkExcWhitelist
    {
        public long Sn { get; set; }
        public string FileId { get; set; }
        public string EpkAccId { get; set; }
        public int ProviderServiceId { get; set; }
        public string Lpr { get; set; }
        public string Epcid { get; set; }
        public string Tid { get; set; }
        public string Function { get; set; }
        public string ChargeType { get; set; }
        public DateTime? ArriveTime { get; set; }
        public DateTime? ExpireTime { get; set; }
        public string TimeIntervalS { get; set; }
        public string TimeIntervalE { get; set; }
        public int ServiceType { get; set; }
        public string VenderCode { get; set; }
        public string ChannelCode { get; set; }
        public DateTime UploadDate { get; set; }
        public int? Version { get; set; }
        public string EpcidCrypt { get; set; }
        public string Indentify { get; set; }
        public string BankAccId { get; set; }
        public string Isfull { get; set; }
        public string VehicleStatus { get; set; }
        public string CarIdentity { get; set; }
        public string AccStatus { get; set; }
        public string ServiceStatus { get; set; }
        public string EtagStatus { get; set; }
        public string EtagModel { get; set; }
        public string ReceiptData { get; set; }
        public string Ein { get; set; }
        public long? SubscribedServiceId { get; set; }
        public int? ServiceItem { get; set; }
        public long? AccPaymentId { get; set; }
        public int? PaymentId { get; set; }
    }
}