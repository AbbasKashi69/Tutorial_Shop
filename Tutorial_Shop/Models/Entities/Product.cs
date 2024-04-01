using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Tutorial_Shop.Models.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Unicode]
        public required string Name { get; set; }

        [StringLength(1000)]
        [Unicode]
        public string? Description { get; set; }

        [Required]
        [Precision(18, 0)]
        public decimal Price { get; set; }

        [Unicode]
        public string? PicturePath { get; set; }

    }
}
