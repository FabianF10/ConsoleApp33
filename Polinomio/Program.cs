using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinomio
{
    class Program
    {
       static void Main(string[] args)
       {

            int a = 3, b = 5, c = 2, d = 7;
            double cinnco, trees,resul;

            cinnco = Math.Pow(a, 5);
            trees  = Math.Pow(b, 3);

            resul = (a-b+c-d);
            Console.WriteLine($"{resul}");

            Console.ReadLine();
       }

    }
        
    
}
