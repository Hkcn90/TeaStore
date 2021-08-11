using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductInventory> ProductInventories { get; set; } = new List<ProductInventory>();
        public ICollection<ProductPhotos> Photos { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = System.DateTime.Now;
    }
}
