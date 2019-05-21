using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Años
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1;

            Console.Write("Digite su nombre ");
            Console.ReadLine();

            Console.Write("Digite su año de nacimiento ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Su edad en el año 2030 sera de: " + (2030 - num1));

            Console.ReadKey();

        }
    }
}
