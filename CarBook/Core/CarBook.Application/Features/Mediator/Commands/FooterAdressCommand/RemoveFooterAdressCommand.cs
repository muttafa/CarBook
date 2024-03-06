using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.FooterAdressCommand
{
    public class RemoveFooterAdressCommand : IRequest
    {
        public int ID { get; set; }

        public RemoveFooterAdressCommand(int id)
        {
            ID = id;
        }
    }
}
