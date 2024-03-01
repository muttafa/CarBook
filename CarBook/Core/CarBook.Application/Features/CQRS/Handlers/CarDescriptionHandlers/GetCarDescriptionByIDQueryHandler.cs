using CarBook.Application.Features.CQRS.Queries.CarDescriptionQueries;
using CarBook.Application.Features.CQRS.Results.CarDescriptions;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarDescriptionHandlers
{
    public class GetCarDescriptionByIDQueryHandler
    {
        private readonly IRepository<CarDescription> _repository;

        public GetCarDescriptionByIDQueryHandler(IRepository<CarDescription> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarDescriptionByIDQueryResult> Handle(GetCarDescriptionByIDQuery query)
        {
            var value = await _repository.GetByIdAsync(query.CarDescriptionID);

            return new GetCarDescriptionByIDQueryResult
            {
                CarDescriptionID = value.CarDescriptionID,
                CarDescriptions = value.CarDescriptions,
                CarID = value.CarID,
            };
        }
    }
}
