using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class PersonalFinanceLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personal Finance Loan Payment Plan Is Calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
