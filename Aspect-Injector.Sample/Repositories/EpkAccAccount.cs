#nullable disable
using System;

namespace Aspect_Injector.Sample.Repositories
{
    public partial class EpkAccAccount
    {
        public string EpkAccId { get; set; }
        public string AccNo { get; set; }
        public string Lpr { get; set; }
        public string IdNo { get; set; }
        public string Name { get; set; }
        public string Tid { get; set; }
        public string EpcId { get; set; }
        public DateTime? InitialTime { get; set; }
        public DateTime? LastSyncTime { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int AclMasterId { get; set; }
        public string NvdisCategory { get; set; }
        public string VehicleStatus { get; set; }
        public string CarIdentity { get; set; }
        public string AccStatus { get; set; }
        public string ServiceStatus { get; set; }
        public string EtagStatus { get; set; }
        public string EpkStatus { get; set; }
        public string EtagModel { get; set; }
        public string AccessStatus { get; set; }
        public string AccessPaymentStatus { get; set; }
        public string ReceiptEin { get; set; }
        public string EpcidCrypt { get; set; }
        public string UtaggoUuid { get; set; }
    }
}