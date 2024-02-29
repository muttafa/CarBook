using CarBook.Application.Interfaces;
using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.CarCommand
{
    public class RemoveCarCommand
    {
        public RemoveCarCommand(int carId)
        {
            CarId = carId;
        }

        public int CarId { get; set; }
    }
}
