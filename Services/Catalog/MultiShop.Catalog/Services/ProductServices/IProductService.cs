using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
	public interface IProductService
	{

		Task<List<ResultProductDto>> GetAllProductAsync(); // Bütün verileri getirecek metod

		Task CreateProductAsync(CreateProductDto createProductDto); // Ekleme İşlemi

		Task UpdateProductAsync(UpdateProductDto updateProductDto); // Güncelleme İşlemi

		Task DeleteProductAsync(string id); // Silme

		Task<GetByIdProductDto> GetByIdProductAsync(string id); // İd ye göre getirme işlemi
	}
}
