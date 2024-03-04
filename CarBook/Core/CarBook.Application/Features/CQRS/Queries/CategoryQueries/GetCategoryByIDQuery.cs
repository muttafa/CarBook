﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.CategoryQueries
{
    public class GetCategoryByIDQuery
    {
        public GetCategoryByIDQuery(int categoryID)
        {
            CategoryID = categoryID;
        }

        public int CategoryID { get; set; }
    }
}
