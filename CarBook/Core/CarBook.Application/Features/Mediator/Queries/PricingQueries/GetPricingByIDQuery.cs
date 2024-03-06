﻿using CarBook.Application.Features.Mediator.Results.PricingResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.PricingQueries
{
    public class GetPricingByIDQuery : IRequest<GetPricingByIDQueryResult>
    {
        public int PricingID { get; set; }

        public GetPricingByIDQuery(int pricingID)
        {
            PricingID = pricingID;
        }
    }
}
