using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Service.Data;
using Service.Dto;
using Service.Entities;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Repository
{
    public class ProductsRepository : IProductService
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        public ProductsRepository(AppDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
        public void AddProduct(Products product)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ProductDto> GetProductAsync(int id)
        {
            return  await _context.Products.Where(x => x.Id == id)
                 .Include(ca => ca.Category)
                 .Include(pr=>pr.ProductInventories)
                 .ProjectTo<ProductDto>(_mapper.ConfigurationProvider)
                 .AsSplitQuery()
                 .SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<ProductDto>> GetAllProductsAsync()
        {
           return  await _context.Products
                 .ProjectTo<ProductDto>(_mapper.ConfigurationProvider)
                 .ToListAsync();

            
        }
    }
}
