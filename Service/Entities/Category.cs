using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryCode { get; set; }
        public string CategoryName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; } = System.DateTime.Now;

    }
}
