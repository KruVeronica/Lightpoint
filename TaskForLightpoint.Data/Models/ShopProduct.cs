using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskForLightpoint.Models
{
    public class ShopProduct
    {
        [Key]
        public Guid Id { get; set; }
        [ForeignKey("Shop")]
        [DisplayName("Shop")]
        public Guid ShopFK { get; set; }
        public Shop Shop { get; set; }
        [ForeignKey("Product")]
        [DisplayName("Product")]
        public Guid ProductFK { get; set; }
        public Product Product { get; set; }
    }
}
