using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.ContactQueries
{
    public class GetContactByIDQuery
    {
        public int ContactID { get; set; }

        public GetContactByIDQuery(int contactID)
        {
            ContactID = contactID;
        }
    }
}
