﻿using MediatR;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MultiShop.Order.Application.Features.Mediator.Commands.OrderingCommands
{
	public class UpdateOrderingCommandHanadler : IRequestHandler<UpdateOrderingCommand>
	{
		private readonly IRepository<Ordering> _repository;

		public UpdateOrderingCommandHanadler(IRepository<Ordering> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateOrderingCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.OrderingId);
			values.OrderDate = request.OrderDate;
			values.UserId = request.UserId;
			values.TotalPrice = request.TotalPrice;
			await _repository.UpdateAsync(values);
		}
	}
}
