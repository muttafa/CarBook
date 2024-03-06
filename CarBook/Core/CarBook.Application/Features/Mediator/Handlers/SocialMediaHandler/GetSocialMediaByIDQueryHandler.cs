using CarBook.Application.Features.Mediator.Queries.ServiceQueries;
using CarBook.Application.Features.Mediator.Queries.SocialMediaQueries;
using CarBook.Application.Features.Mediator.Results.ServiceResults;
using CarBook.Application.Features.Mediator.Results.SocialMediaResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.SocialMediaHandler
{
    public class GetSocialMediaByIDQueryHandler : IRequestHandler<GetSocialMediaByIDQuery, GetSocialMediaByIDQueryResult>
    {
        private readonly IRepository<SocialMedia> _repository;

        public GetSocialMediaByIDQueryHandler(IRepository<SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetSocialMediaByIDQueryResult> Handle(GetSocialMediaByIDQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.id);

            return new GetSocialMediaByIDQueryResult
            {
                Icon = value.Icon,
                SocialMediaUrl = value.SocialMediaUrl,
                SocialMediaId = value.SocialMediaId,
                Name = value.Name,
                            };
        }
    
    }
}
