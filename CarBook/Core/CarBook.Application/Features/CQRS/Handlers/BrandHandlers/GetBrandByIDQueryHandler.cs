using CarBook.Application.Features.CQRS.Queries.BannerQueries;
using CarBook.Application.Features.CQRS.Queries.BrandQueries;
using CarBook.Application.Features.CQRS.Results.BannerResults;
using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.BrandHandlers
{
    public class GetBrandByIDQueryHandler
    {
        private readonly IRepository<Brand> _repository;

        public GetBrandByIDQueryHandler(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandByIDQueryResult> Handler(GetBrandByIDQuery query)
        {
            var values = await _repository.GetByIdAsync(query.BrandID);

            return new GetBrandByIDQueryResult
            {
                BrandID = values.BrandID,
                Name = values.Name,
            };
        }
    }
}
