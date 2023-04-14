using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Category : EntityBase
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Product> ProductList { get; set; }
        [InverseProperty(nameof(ParentCategory))]
        public virtual ICollection<Category> CategoryList { get; set; }
        [ForeignKey(nameof(ParentId))]
        public Category ParentCategory { get; set; }
    }
}