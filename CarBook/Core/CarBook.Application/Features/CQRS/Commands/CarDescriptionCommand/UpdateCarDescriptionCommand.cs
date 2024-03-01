using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.CarDescriptionCommand
{
    public class UpdateCarDescriptionCommand
    {
        public int CarDescriptionID { get; set; }
        public int CarID { get; set; }
        public string CarDescriptions { get; set; }
    }
}
