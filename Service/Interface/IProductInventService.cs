using Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Interface
{
    public interface IProductInventService
    {
        Task<IEnumerable<ProductInventory>> GetProductInventoriesAsync(string productId);
    }
}
