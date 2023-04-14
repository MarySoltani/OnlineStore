using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class OrderItem : EntityBase
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
		public int OrderId { get; set; }
		public int Unit { get; set; } //واحد نگهداری مثل کارتن، بسته و ...
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime CreateDate { get; set; }
        public string? Description { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
