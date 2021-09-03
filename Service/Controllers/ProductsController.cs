using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Dto;
using Service.Entities;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly IMapper _mapper;
        private readonly IProductService _iProducts;
        public ProductsController(IProductService iProducts, IMapper mapper)
        {
            _iProducts = iProducts;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetAllProducts()
        {
            var products = await _iProducts.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("{id}", Name = "GetAllProduct")]
        public async Task<ActionResult<ProductDto>> GetAllProduct(int id)
        {
            var product = await _iProducts.GetProductAsync(id);
            return Ok(product);
        }
        [HttpPost("AddProduct")]
        public  ActionResult<string> SaveProduct([FromBody] ProductDto productDto)
        {
           var status=  _iProducts.AddProduct(productDto);
            return status.ToString();
        }

    }
}
