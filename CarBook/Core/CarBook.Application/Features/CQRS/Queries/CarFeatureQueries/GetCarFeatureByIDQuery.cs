using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.CarFeatureQueries
{
    public class GetCarFeatureByIDQuery
    {
        public GetCarFeatureByIDQuery(int carFeatureID)
        {
            CarFeatureID = carFeatureID;
        }

        public int CarFeatureID { get; set; }
    }
}
