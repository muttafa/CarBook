using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.CarDescriptionCommand
{
    public class RemoveCarDescriptionCommand
    {
        public RemoveCarDescriptionCommand(int carDescriptionID)
        {
            CarDescriptionID = carDescriptionID;
        }

        public int CarDescriptionID { get; set; }
    }
}
