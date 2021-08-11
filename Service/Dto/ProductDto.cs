using Service.Entities;
using System;
using System.Collections.Generic;

namespace Service.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductInventory> ProductInventories { get; set; }
        public ICollection<ProductPhotos> Photos { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = System.DateTime.Now;
    }
}
