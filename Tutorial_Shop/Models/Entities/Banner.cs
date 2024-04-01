using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Tutorial_Shop.Models.Entities
{
    public class Banner
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode]
        public required string Title { get; set; }

        [Required]
        [Unicode]
        public required string PicturePath { get; set; }
    }
}
