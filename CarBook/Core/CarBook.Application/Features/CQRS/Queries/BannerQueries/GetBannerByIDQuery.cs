using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.BannerQueries
{
    public class GetBannerByIDQuery
    {
        public GetBannerByIDQuery(int bannerID)
        {
            BannerID = bannerID;
        }

        public int BannerID { get; set; }
    }
}
