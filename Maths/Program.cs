using System.Security.Cryptography.X509Certificates;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            Arithmetic arithmetic = new Arithmetic();
            arithmetic.Sum(10,5);
            arithmetic.Sub(9, 2);
            arithmetic.Mul(5, 7);
            arithmetic.Div(24, 2);
        }
    }
}