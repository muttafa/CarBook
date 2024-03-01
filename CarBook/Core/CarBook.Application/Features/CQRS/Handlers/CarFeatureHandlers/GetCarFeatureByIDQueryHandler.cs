using CarBook.Application.Features.CQRS.Queries.CarFeatureQueries;
using CarBook.Application.Features.CQRS.Results.CarFeatures;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.CarFeatureHandlers
{
    public class GetCarFeatureByIDQueryHandler
    {
        private readonly IRepository<CarFeature> _repository;

        public GetCarFeatureByIDQueryHandler(IRepository<CarFeature> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarFeaturesByIDQueryResult> Handle(GetCarFeatureByIDQuery query)
        {
            var value = await _repository.GetByIdAsync(query.CarFeatureID);

            return new GetCarFeaturesByIDQueryResult
            {
                Avaible = value.Avaible,
                CarFeatureID = value.CarFeatureID,
                CarID = value.CarID,
                FeatureID = value.FeatureID,
            };
        }
    }
}
