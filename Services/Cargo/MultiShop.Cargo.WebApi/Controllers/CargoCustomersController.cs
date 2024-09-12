﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoCompanyDtos;
using MultiShop.Cargo.DtoLayer.Dtos.CargoCustomerDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class CargoCustomersController : ControllerBase
	{
		private readonly ICargoCustomerService _cargoCustomerService;

		public CargoCustomersController(ICargoCustomerService cargoCustomerService)
		{
			_cargoCustomerService = cargoCustomerService;
		}

		[HttpGet]
		public IActionResult CargoCustomerList()
		{
			var values = _cargoCustomerService.TGetAll();
			return Ok(values);
		}
		[HttpGet("{id}")]
		public IActionResult GetCargoCustomersById(int id)
		{
			var value = _cargoCustomerService.TGetById(id);
			return Ok(value);
		}
		[HttpPost]
		public IActionResult CreateCargoCustomer(CreateCargoCustomerDto createCargoCustomerDto)
		{
			CargoCustomer cargoCustomer = new CargoCustomer()
			{
				Address = createCargoCustomerDto.Address,
				City = createCargoCustomerDto.City,
				District = createCargoCustomerDto.District,
				Email = createCargoCustomerDto.Email,
				Name = createCargoCustomerDto.Name,
				Phone = createCargoCustomerDto.Phone,
				SurName = createCargoCustomerDto.SurName,
			};
			_cargoCustomerService.TInsert(cargoCustomer);
			return Ok("Kargo Müşteri Ekleme İşlemi Başarıyla Yapıldı");

		}
		[HttpDelete]
		public IActionResult RemoveCargoCustomer(int id)
		{
			_cargoCustomerService.TDelete(id);
			return Ok("Kargo Müşteri Silme İşlemi Başarıyla Yapıldı");
		}
		[HttpPut]
		public IActionResult UpdateCargoCustomer(UpdateCargoCustomerDto updateCargoCustomerDto)
		{
			CargoCustomer cargoCustomer = new CargoCustomer()
			{
				Address = updateCargoCustomerDto.Address,
				City = updateCargoCustomerDto.City,
				CargoCustomerId = updateCargoCustomerDto.CargoCustomerId,
				Email = updateCargoCustomerDto.Email,
				District = updateCargoCustomerDto.District,
				Name = updateCargoCustomerDto.Name,
				Phone = updateCargoCustomerDto.Phone,
				SurName = updateCargoCustomerDto.SurName,
				
			};
			_cargoCustomerService.TUpdate(cargoCustomer);
			return Ok("Kargo Müşteri Güncelleme işlemi başarıyla yapıldı");
		}



	}
}
