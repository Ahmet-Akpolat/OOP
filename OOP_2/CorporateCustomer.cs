using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class CorporateCustomer : Customer
    {
        public string CompanyName { get; set; }
        public string TaxNum { get; set; }
    }
}
