using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.CarDescriptions
{
    public class GetCarDescriptionByIDQueryResult
    {
        public int CarDescriptionID { get; set; }
        public int CarID { get; set; }
        public string CarDescriptions { get; set; }
    }
}
