using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Order
    {
        public int Id { get; set; }
		public int UserId { get; set; }
		public byte Status { get; set; }
		public decimal SubTotalPrice { get; set; } //قیمت یه آیتم خاص
		public decimal ItemDiscount { get; set; } //تخفیف یک آیتم خاص
		public decimal Shipping { get; set; } //هزینه ارسال
		public decimal TotalPrice { get; set; } //قیمت کل با مالیات و هزینه ارسال بدون تخفیف
		public decimal Discount { get; set; } //تخفیف روی کل فاکتور
		public decimal GrandTotalPrice { get; set; } //مبلغ قابل پرداخت
		public int Quantity { get; set; }
        public string CreateDate { get; set; }
        public string? Description { get; set; }
		public virtual ICollection<OrderItem> OrderItemList { get; set; }
	}
}
