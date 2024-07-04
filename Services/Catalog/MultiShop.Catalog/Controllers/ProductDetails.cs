using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Entites;
using MultiShop.Catalog.Services.ProductDetailDetailServices;

namespace MultiShop.Catalog.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductDetails : ControllerBase
	{
		private IProductDetailService _productDetailService;

		public ProductDetails(IProductDetailService productDetailService)
		{
			_productDetailService = productDetailService;
		}
		[HttpGet]
		public async Task<IActionResult> ProductDetailList()
		{
			var values = await _productDetailService.GettAllProductDetailAsync();
			return Ok(values);
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetProductDetailId(string id)
		{
			var values = await _productDetailService.GetByIdProductDetailAsync(id);
			return Ok(values);
		}
		[HttpPost]
		public async Task<IActionResult> CreateProductDetail(CreateProductDetailDto createProductDetailDto)
		{
			var values =  _productDetailService.CreateProductDetailAsync(createProductDetailDto);
			return Ok("Ürün Bilgisi Başarıyla Eklendi");

		}
		[HttpDelete]
		public async Task<IActionResult>DeleteProductDetail(string id)
		{
			var values = _productDetailService.DeleteProductDetailAsync(id);
			return Ok("Ürün Bilgisi Başarıyla Silindi");
		}
		[HttpPut]
		public async Task<IActionResult> UpdateProductDetail(UpdateProductDetailDto updateProductDetailDto)
		{
			var values = _productDetailService.UpdateProductDetailAsync(updateProductDetailDto);
			return Ok("Ürün Bilgisi Başarıyla Güncellendi");
		}
	}
}
