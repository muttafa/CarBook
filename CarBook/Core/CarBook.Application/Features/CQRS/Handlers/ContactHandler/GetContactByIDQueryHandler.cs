using CarBook.Application.Features.CQRS.Queries.CategoryQueries;
using CarBook.Application.Features.CQRS.Queries.ContactQueries;
using CarBook.Application.Features.CQRS.Results.CategoryResults;
using CarBook.Application.Features.CQRS.Results.ContactResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandler
{
    public class GetContactByIDQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactByIDQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIDQueryResult> Handle(GetContactByIDQuery query)
        {
            var value = await _repository.GetByIdAsync(query.ContactID);

            return new GetContactByIDQueryResult
            {
                ContactID = value.ContactID,
                Subject = value.Subject,
                SendDate = value.SendDate,
                Name = value.Name,
                Message = value.Message,
                Email = value.Email 
            };
        }
    }
}
