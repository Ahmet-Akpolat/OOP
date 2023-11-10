using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maths
{
    public class Arithmetic
    {
        public void Sum(int num1, int num2)
        {
            var sum = num1 + num2;
            Console.WriteLine("Result : " + sum);
        }

        public void Sub(int num1, int num2)
        {
            var sub = num1 - num2;
            Console.WriteLine("Result : " + sub);
        }

        public void Mul(int num1, int num2)
        {
            var mul = num1 * num2;
            Console.WriteLine("Result : " + mul);
        }

        public void Div(int num1, int num2)
        {
            var div = num1 / num2;
            Console.WriteLine("Result : " + div);
        }
    }
}
