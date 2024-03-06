using CarBook.Application.Features.Mediator.Queries.FooterAdressQueries;
using CarBook.Application.Features.Mediator.Results.FooterAdressResults;
using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAdressHandlers
{
    public class GetFooterAdressByIDQueryHandler : IRequestHandler<GetFooterAdressByIDQuery, GetFooterAdressByIDQueryResult>
    {
        private readonly IRepository<FooterAdress> _repository;

        public GetFooterAdressByIDQueryHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAdressByIDQueryResult> Handle(GetFooterAdressByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ID);

            return new GetFooterAdressByIDQueryResult
            {
                Description = values.Description,
                FooterAdressID = values.FooterAdressID,
                Mail = values.Mail,
                PhoneNumber = values.PhoneNumber,
            };
        }
    }
}
