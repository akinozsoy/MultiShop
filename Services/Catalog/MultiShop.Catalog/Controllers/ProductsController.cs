using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Dtos.ProductDtos;
using Microsoft.AspNetCore.Authorization;
using MultiShop.Catalog.Services.ProductServices;

namespace MultiShop.Catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}
		[HttpGet]
		public async Task<IActionResult> ProductList()
		{
			var values = await _productService.GettAllProductAsync();
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult>GetProductById(string id)
		{
			var values = _productService.GetByIdProductAsync(id);
			return Ok(values);
		}
		[HttpPost]
		public async Task<IActionResult>CreateProduct(CreateProductDto createProductDto)
		{
			var values = _productService.CreateProductAsync(createProductDto);
			return Ok("Ürün Başarıyla Eklendi");
		}
		[HttpDelete]
		public async Task<IActionResult>DeleteProduct(string id)
		{
			var values = _productService.DeleteProductAsync(id);
			return Ok("Ürün Başarıyla Silindi");
		}
		[HttpPut]
		public async Task<IActionResult>UpdateProduct(UpdateProductDto updateProductDto)
		{
			var values = _productService.UpdateProductAsync(updateProductDto);
			return Ok("Ürün Başarıyla Güncellendi");
		}

	}
}
