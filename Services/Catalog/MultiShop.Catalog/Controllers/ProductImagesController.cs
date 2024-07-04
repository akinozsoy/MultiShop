using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Services.ProductImageServices;

namespace MultiShop.Catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductImagesController : ControllerBase
	{
		private readonly IProductImageService _productImageService;

		public ProductImagesController(IProductImageService productImageService)
		{
			_productImageService = productImageService;
		}
		[HttpGet]
		public async Task<IActionResult> ProductImageList()
		{
			var values = await _productImageService.GettAllProductImageAsync();
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetProductImageById(string id)
		{
			var values = _productImageService.GetByIdProductImageAsync(id);
			return Ok(values);
		}
		[HttpPost]
		public async Task<IActionResult>CreateProductImage(CreateProductImageDto createProductImageDto)
		{
			var values = _productImageService.CreateProductImageAsync(createProductImageDto);
			return Ok("Ürün Görselleri Başarıyla Eklendi ");
		}
		[HttpDelete]
		public async Task<IActionResult>DeleteProductImage(string id)
		{
			var values = _productImageService.DeleteProductImageAsync(id);
			return Ok("Ürün Görselleri başarıyla Silindi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateProductImage(UpdateProductImageDto updateProductImageDto)
		{
			var values = _productImageService.GetByProductIdProductImageAsync(updateProductImageDto.ProductId);
			return Ok("Ürün Görselleri Başarıyla Güncelleştirildi");
		}
	}
}
