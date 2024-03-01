using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Results.CarFeatures
{
    public class GetCarFeaturesByIDQueryResult
    {
        public int CarFeatureID { get; set; }
        public int CarID { get; set; }
        public int FeatureID { get; set; }
        public bool Avaible { get; set; }
    }
}
