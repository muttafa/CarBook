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
    public class RemoveCarFeatureCommandHandler
    {
        private readonly IRepository<CarFeature> _repository;

        public RemoveCarFeatureCommandHandler(IRepository<CarFeature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCarFeatureCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarFeatureID);

            await _repository.RemoveAsync(value);
        }
    }
}
