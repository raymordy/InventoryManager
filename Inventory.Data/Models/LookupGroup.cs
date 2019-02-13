using System.ComponentModel.DataAnnotations;

namespace Inventory.Data.Models
{
    public class LookupGroup
    {
        [Key]
        public int Id { get; set; }
        public string GroupDescription { get; set; }
    }
}