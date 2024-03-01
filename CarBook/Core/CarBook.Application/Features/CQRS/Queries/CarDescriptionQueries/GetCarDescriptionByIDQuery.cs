using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.CarDescriptionQueries
{
    public class GetCarDescriptionByIDQuery
    {
        public GetCarDescriptionByIDQuery(int carDescriptionID)
        {
            CarDescriptionID = carDescriptionID;
        }

        public int CarDescriptionID { get; set; }
    }
}
