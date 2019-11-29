using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskForLightpoint.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public ICollection<ShopProduct> ShopProducts { get; set; }
    }
}
