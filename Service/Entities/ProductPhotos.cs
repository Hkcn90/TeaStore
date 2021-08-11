using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Entities
{
    public class ProductPhotos
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool IsMain { get; set; }
        public Products Product { get; set; }
        public int AppUserId { get; set; }
    }
}
