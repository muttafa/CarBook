using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.FooterAdressCommand
{
    public class CreateFooterAdressCommand : IRequest
    {
        public string Description { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
    }
}
