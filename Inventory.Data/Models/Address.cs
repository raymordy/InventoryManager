using System;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Data.Models
{
    public class Address
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Line 1 is required")]
        public string Line1 { get; set; }
        [Required(ErrorMessage = "Line 2 is required")]
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        [Required(ErrorMessage = "Post Code is required")]
        public string PostCode { get; set; }
        public string Country { get; set; }
    }
}
