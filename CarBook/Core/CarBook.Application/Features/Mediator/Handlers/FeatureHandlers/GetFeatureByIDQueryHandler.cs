using CarBook.Application.Features.Mediator.Queries.FeatureQueries;
using CarBook.Application.Features.Mediator.Results.FeatureResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.FeatureHandlers
{
    public class GetFeatureByIDQueryHandler : IRequestHandler<GetFeatureByIDQuery, GetFeatureByIDQueryResult>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureByIDQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIDQueryResult> Handle(GetFeatureByIDQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);

            return new GetFeatureByIDQueryResult
            {
                FeatureId = value.FeatureId,
                Name = value.Name,
            };
        }
    }
}
