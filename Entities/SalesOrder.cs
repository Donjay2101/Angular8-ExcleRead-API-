using System;

namespace OER2.WebApi.Entities
{
    public class SalesOrder:BaseEntity
    {
        public string No { get; set; }
        public string Plant { get; set; }
        public DateTime RequestedDeliveryDate { get; set; }
        public string MaterialDescription { get; set; }
        public double PendingDeliveryQty { get; set; }
        public string SalesDoc { get; set; } 
        public string DomorExp { get; set; }
        public string IncoTermsPI { get; set; }
        public string IncoTermsPII { get; set; }
        public string Orderstatus { get; set; }
        public string SoldToName { get; set; }
        public string ShipToName { get; set; }
        public string DeliveryStatus { get; set; }
        public int Central { get; set; }
        public int North { get; set; }
        public int South { get; set; }
        public int EC { get; set; }
        public string Total { get; set; }
    }
}
