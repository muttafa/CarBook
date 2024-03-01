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
    public class GetCarFeatureQueryHandler
    {
        private readonly IRepository<CarFeature> _repository;

        public GetCarFeatureQueryHandler(IRepository<CarFeature> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarFeaturesQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetCarFeaturesQueryResult
            {
                Avaible = x.Avaible,
                CarFeatureID = x.CarFeatureID,
                CarID = x.CarID,
                FeatureID = x.FeatureID,
            }).ToList();
        }
    }
}
