using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Commands.ContactCommand
{
    public class RemoveContactCommand
    {
        public int ContactID { get; set; }

        public RemoveContactCommand(int contactID)
        {
            ContactID = contactID;
        }
    }
}
