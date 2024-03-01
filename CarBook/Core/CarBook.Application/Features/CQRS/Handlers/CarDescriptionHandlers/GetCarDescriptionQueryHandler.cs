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
    public class GetCarDescriptionQueryHandler
    {
        private readonly IRepository<CarDescription> _repository;

        public GetCarDescriptionQueryHandler(IRepository<CarDescription> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarDescriptionQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetCarDescriptionQueryResult
            {
                CarDescriptionID = x.CarDescriptionID,
                CarDescriptions = x.CarDescriptions,
                CarID = x.CarID,
            }).ToList();
        }
    }
}
