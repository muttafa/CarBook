﻿using CarBook.Application.Features.Mediator.Results.ServiceResults;
using CarBook.Application.Features.Mediator.Results.SocialMediaResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Queries.SocialMediaQueries
{
    public class GetSocialMediaByIDQuery : IRequest<GetSocialMediaByIDQueryResult>
    {
        public GetSocialMediaByIDQuery(int id)
        {
            this.id = id;
        }

        public int id { get; set; }
    }
}
