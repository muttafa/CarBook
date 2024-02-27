using CarBook.Application.Features.CQRS.Queries.AboutQueries;
using CarBook.Application.Features.CQRS.Results.AboutResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class GetAboutByIDQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIDQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIDQueryResult> Handle(GetAboutByIDQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetAboutByIDQueryResult
            {
                AboutID = value.AboutID,
                Description = value.Description,
                ImageURl = value.ImageURl,
                Title = value.Title,
            };
        }
    }
}
