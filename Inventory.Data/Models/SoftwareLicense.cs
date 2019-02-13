using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Data.Models
{
    public class SoftwareLicense
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public LookupType Type { get; set; }
        public Vendor Vendor { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public decimal Net { get; set; }
        public List<Renewal> Renewals { get; set; }
    }
}
