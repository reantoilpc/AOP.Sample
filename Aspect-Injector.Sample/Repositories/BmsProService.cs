#nullable disable
namespace Aspect_Injector.Sample.Repositories
{
    public partial class BmsProService
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDesc { get; set; }
        public int? ServiceParentId { get; set; }
        public string GroupId { get; set; }
        public int? GroupType { get; set; }
        public int PricingModel { get; set; }
        public int PricingUnit { get; set; }
        public int PricingQty { get; set; }
        public decimal Price { get; set; }
    }
}