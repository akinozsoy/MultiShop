using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace MultiShop.Discount.Context
{
	public class DapperContext : DbContext
	{
		private readonly IConfiguration _configuration;
		private readonly string _connectionString;

		public DapperContext(IConfiguration configuration)
		{
			_configuration = configuration;
			_connectionString = _configuration.GetConnectionString("DefaultConnection");
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-3LAT6B2;initial Catalog=MultiShopDiscountDb;integrated Security=true");
		}
		public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
