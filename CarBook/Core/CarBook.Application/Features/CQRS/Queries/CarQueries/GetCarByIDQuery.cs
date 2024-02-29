using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.CarQueries
{
    public class GetCarByIDQuery
    {
        public GetCarByIDQuery(int carId)
        {
            CarId = carId;
        }

        public int CarId { get; set; }
    }
}
