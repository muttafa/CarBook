﻿using CarBook.Application.Features.Mediator.Queries.PricingQueries;
using CarBook.Application.Features.Mediator.Queries.ServiceQueries;
using CarBook.Application.Features.Mediator.Results.PricingResults;
using CarBook.Application.Features.Mediator.Results.ServiceResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.ServiceHandlers
{
    public class GetServiceByIDQueryHandler : IRequestHandler<GetServiceByIDQuery, GetServiceByIDQueryResult>
    {
        private readonly IRepository<Service> _repository;

        public GetServiceByIDQueryHandler(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIDQueryResult> Handle(GetServiceByIDQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ServiceId);

            return new GetServiceByIDQueryResult
            {
                Title = value.Title,
                Description = value.Description,
                ServiceId = value.ServiceId,
                Icon = value.Icon,
            };
        }
 
    }
}
