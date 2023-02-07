#nullable disable
using System;

namespace Aspect_Injector.Sample.Repositories
{
    public partial class EpkProProviderService
    {
        public int ProviderServiceId { get; set; }
        public int ServiceId { get; set; }
        public int ProviderId { get; set; }
        public int ContractId { get; set; }
        public int PricingModel { get; set; }
        public int PricingUnit { get; set; }
        public int PricingQty { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public string UseByCampaign { get; set; }
        public DateTime ActiveTime { get; set; }
        public DateTime? InactiveTime { get; set; }
        public string ProviderServiceName { get; set; }
        public int? SaId { get; set; }
        public bool? SubscribedFlag { get; set; }
        public string Siteinfocode { get; set; }
        public string RoamingCode { get; set; }
        public int? OpenFilter { get; set; }
        public int? FilterDay { get; set; }
        public int? FilterWriteoffCount { get; set; }
    }
}