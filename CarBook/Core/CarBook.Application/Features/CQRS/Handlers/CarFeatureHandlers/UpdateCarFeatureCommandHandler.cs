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
    public class UpdateCarFeatureCommandHandler
    {
        private readonly IRepository<CarFeature> _repository;

        public UpdateCarFeatureCommandHandler(IRepository<CarFeature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarFeatureCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarFeatureID);

            value.CarFeatureID = command.CarFeatureID;
            value.FeatureID = command.FeatureID;
            value.CarID = command.CarID;
            value.Avaible = command.Avaible;
            

            await _repository.UpdateAsync(value);
        }
    }
}
