using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio;

            Console.Write("digite el radio ");
            radio = double.Parse(Console.ReadLine());

            Console.WriteLine("el volumen es " + (4 / 3 * 3.14 * radio * radio * radio));

            Console.ReadKey();
        }
    }
}
