
using System.ComponentModel.DataAnnotations;

namespace CQRS_Library.Data.Models
{
    public class Items
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
