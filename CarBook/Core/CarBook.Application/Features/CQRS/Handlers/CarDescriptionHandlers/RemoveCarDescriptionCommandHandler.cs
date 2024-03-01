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
    public class RemoveCarDescriptionCommandHandler
    {
        private readonly IRepository<CarDescription > _repository;

        public RemoveCarDescriptionCommandHandler(IRepository<CarDescription> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCarDescriptionCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarDescriptionID);

            await _repository.RemoveAsync(value);
        }
    }
}
