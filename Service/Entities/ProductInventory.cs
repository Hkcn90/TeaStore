using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Entities
{
    public class ProductInventory
    {
        public int Id { get; set; }
        public string Unit { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public string ProductCode { get; set; }
        public Products Product { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = System.DateTime.Now;
    }
}
