using Microsoft.EntityFrameworkCore;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccessLayer.Concrete
{
	public class CargoContext :DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost,1441;initial Catalog=MultiShopCargoDb;User=sa;Password=Dizayn1453*");
		}

		public DbSet<CargoCompany>CargoCompanies { get; set; }
		public DbSet<CargoDetail>CargoDetail { get; set; }
		public DbSet<CargoCustomer>CargoCustomers { get; set; }
		public DbSet<CargoOperation>CargoOpertaions { get; set; }
    }
}
