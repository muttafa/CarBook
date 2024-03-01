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
    public class CreateCarDescriptionCommandHandler
    {
        private readonly IRepository<CarDescription> _repository;

        public CreateCarDescriptionCommandHandler(IRepository<CarDescription> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarDescriptionCommand command)
        {
            await _repository.CreateAsync(new CarDescription
            {
                CarID = command.CarID,
                CarDescriptions = command.CarDescriptions,
            });
        }
    }
}
