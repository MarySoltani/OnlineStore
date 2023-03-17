using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Product
	{
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short Unit { get; set; } //واحد نگهداری مثل کارتن، بسته و ...
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public string CreateDate { get; set; }
        public Category Category { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
