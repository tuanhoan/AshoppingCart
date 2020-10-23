using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AShoppingCart.Data
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public List<Cart> LineItems { get; set; } = new List<Cart>();
    }
    [Table("LineItem")]
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1000)]
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        [MaxLength(10000)]
        public string Image { get; set; }
    }
}
