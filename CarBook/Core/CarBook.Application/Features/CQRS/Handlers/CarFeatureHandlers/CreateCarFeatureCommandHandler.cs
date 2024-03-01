using CarBook.Application.Features.CQRS.Commands.CarFeatureCommand;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarFeatureHandlers
{
    public class CreateCarFeatureCommandHandler
    {
        private readonly IRepository<CarFeature> _repository;

        public CreateCarFeatureCommandHandler(IRepository<CarFeature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarFeatureCommand command)
        {
            await _repository.CreateAsync(new CarFeature
            {
                Avaible = command.Avaible,
                CarID = command.CarID,
                FeatureID = command.FeatureID,
            });


        }
    }
}
