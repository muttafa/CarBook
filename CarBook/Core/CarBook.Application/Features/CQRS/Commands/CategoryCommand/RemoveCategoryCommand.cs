using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.CategoryCommand
{
    public class RemoveCategoryCommand
    {
        public int CategoryID { get; set; }

        public RemoveCategoryCommand(int categoryID)
        {
            CategoryID = categoryID;
        }
    }
}
