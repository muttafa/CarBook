using CarBook.Application.Features.Mediator.Queries.PricingQueries;
using CarBook.Application.Features.Mediator.Results.PricingResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class GetPricingByIDQueryHandler : IRequestHandler<GetPricingByIDQuery, GetPricingByIDQueryResult>
    {
        private readonly IRepository<Pricing> _repository;

        public GetPricingByIDQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<GetPricingByIDQueryResult> Handle(GetPricingByIDQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.PricingID);

            return new GetPricingByIDQueryResult
            {
                PricingID = value.PricingID,
                Name = value.Name,
            };
        }
    }
}
