using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomio1
{
    class Program
    {
        static void Main(string[] args)

        {
           

            int x = 0; 

            Console.Write("Digite el valor de x: ");

            var xa = Console.ReadLine();
            var rxa = int.TryParse(xa, out x);

            int resul = ((3 * (x * x * x * x * x)) - (5 * (x * x * x)) + (2 * x) - 7);
            Console.WriteLine($"El resultado es: {resul}");


            Console.ReadLine();
        }
    }
}
