using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Data.Models
 
{
    public class Renewal
    {
        [Key]
        public int Id { get; set; }
        public LookupType RenewalType { get; set; }
        public string Description { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string PurchaseOrder { get; set; }
        public string Invoice { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? Expiration { get; set; }
        public decimal Net { get; set; }
        public Vendor Vendor { get; set; }
    }
}