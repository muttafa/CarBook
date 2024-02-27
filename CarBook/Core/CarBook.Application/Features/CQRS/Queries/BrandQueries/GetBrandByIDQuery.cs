using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.BrandQueries
{
    public class GetBrandByIDQuery
    {
        public GetBrandByIDQuery(int brandID)
        {
            BrandID = brandID;
        }

        public int BrandID { get; set; }
    }
}
