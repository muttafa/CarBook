using CarBook.Application.Features.CQRS.Queries.BannerQueries;
using CarBook.Application.Features.CQRS.Results.BannerResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIDQueryHandler
    {
        private readonly IRepository<Banner> _repository ;

        public GetBannerByIDQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIDQueryResult> Handler(GetBannerByIDQuery query)
        {
            var values = await _repository.GetByIdAsync(query.BannerID);

            return new GetBannerByIDQueryResult
            {
                BannerID = query.BannerID,
                Description = values.Description,
                Title = values.Title,
                VideoDescription = values.VideoDescription,
                VideoURL = values.VideoURL,
            };
        }
    }
}
