using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class MortgageLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Mortgage Loan Payment Plan Is Calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
