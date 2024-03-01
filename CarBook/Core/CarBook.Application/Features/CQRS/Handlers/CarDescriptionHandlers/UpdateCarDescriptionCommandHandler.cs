using CarBook.Application.Features.CQRS.Commands.CarDescriptionCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarDescriptionHandlers
{
    public class UpdateCarDescriptionCommandHandler
    {
        private readonly IRepository<CarDescription > _repository;

        public UpdateCarDescriptionCommandHandler(IRepository<CarDescription> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarDescriptionCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarDescriptionID);

            value.CarDescriptionID = command.CarDescriptionID;
            value.CarDescriptions = command.CarDescriptions;
            value.CarID = command.CarID;

            await _repository.UpdateAsync(value);
        }
    }
}
