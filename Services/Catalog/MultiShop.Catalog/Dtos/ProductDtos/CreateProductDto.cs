namespace MultiShop.Catalog.Dtos.ProductDtos
{
	public class CreateProductDto
	{

		public string ProductName { get; set; }  // Ürünün Adı

		public decimal ProductPrice { get; set; }  // Ürünün Fiyatı

		public string ProductImageUrl { get; set; } // Ürünün Resmi

		public string ProductDescription { get; set; } // Ürün Açıklaması
	}
}
