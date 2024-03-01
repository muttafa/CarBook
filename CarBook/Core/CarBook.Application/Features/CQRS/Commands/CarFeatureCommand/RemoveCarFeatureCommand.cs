using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.CarFeatureCommand
{
    public class RemoveCarFeatureCommand
    {
        public RemoveCarFeatureCommand(int carFeatureID)
        {
            CarFeatureID = carFeatureID;
        }

        public int CarFeatureID { get; set; }
    }
}
