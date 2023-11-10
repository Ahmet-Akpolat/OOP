using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    internal class VehicleLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle Loan Payment Plan Is Calculated!");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
