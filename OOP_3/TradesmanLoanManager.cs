using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class TradesmanLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Tradesman Loan Payment Plan Is Calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
