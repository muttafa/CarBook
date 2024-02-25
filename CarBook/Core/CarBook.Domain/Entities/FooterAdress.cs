using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class FooterAdress
    {
        public int FooterAdressID { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }

    }
}
