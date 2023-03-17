using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Category
	{
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Product> ProductList { get; set; }
        public virtual ICollection<Category> CategoryList { get; set; }
    }
}