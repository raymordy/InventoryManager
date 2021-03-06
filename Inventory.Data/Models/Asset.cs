﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventory.Data.Models
{
    public class Asset
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public Vendor Vendor { get; set; }
        public LookupType AssetType { get; set; }
        public List<Warranty> Warranties { get; set; }
    }
}
