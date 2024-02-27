using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.BrandCommand
{
    public class RemoveBrandCommand
    {
        public RemoveBrandCommand(int brandID)
        {
            BrandID = brandID;
        }

        public int BrandID { get; set; }
    }
}
