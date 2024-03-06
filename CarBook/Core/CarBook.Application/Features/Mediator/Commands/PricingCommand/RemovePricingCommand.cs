﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.PricingCommand
{
    public class RemovePricingCommand : IRequest
    {
        public int PricingID { get; set; }

        public RemovePricingCommand(int pricingID)
        {
            PricingID = pricingID;
        }
    }
}
