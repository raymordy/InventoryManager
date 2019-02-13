using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Data.Models
{
    public class Vendor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Address> Locations { get; set; }
        public string PhoneNumber { get; set; }
        public string AccountManager { get; set; }
    }
}
