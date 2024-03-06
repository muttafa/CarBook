using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Features.Mediator.Queries.LocationQueries;
using CarBook.Application.Features.Mediator.Results.LocationResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.LocationHandlers
{
    public class GetLocationByIDQueryHandler : IRequestHandler<GetLocationByIDQuery, GetLocationByIDQueryResult>
    {
        private readonly IRepository<Location> _repository;

        public GetLocationByIDQueryHandler(IRepository<Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIDQueryResult> Handle(GetLocationByIDQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);

            return new GetLocationByIDQueryResult
            {
                LocationID = value.LocationID,
                Name = value.Name,
            };
        }
    }
}
