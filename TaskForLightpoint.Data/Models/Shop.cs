using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskForLightpoint.Models
{
    public class Shop
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Adress { get; set; }
        [Required]
        [StringLength(50)]
        public string OpeningHours { get; set; }
        public ICollection<ShopProduct> ShopProducts { get; set; }
    }
}
