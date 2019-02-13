using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Data.Models
{
    public class LookupType
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public LookupGroup TypeLookup { get; set; }
    }
}
