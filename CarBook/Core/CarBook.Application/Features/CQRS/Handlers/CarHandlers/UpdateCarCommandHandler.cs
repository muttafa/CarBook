using CarBook.Application.Features.CQRS.Commands.CarCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarId);

            value.Transmission = command.Transmission;
            value.BigImageURL = command.BigImageURL;
            value.BrandID = command.BrandID;
            value.Fuel = command.Fuel;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Km =command.Km;
            value.Seat = command.Seat;
            value.Model = command.Model;
            value.Luggage = command.Luggage;
            
            await _repository.UpdateAsync(value);
        
        }
    }
}
