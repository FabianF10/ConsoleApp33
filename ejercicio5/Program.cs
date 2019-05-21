using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int car = '\0';
            int car2= '\0';
            Console.Write("Carácter: ");
            car = (int)Console.Read();
            Console.WriteLine(car);


            Console.Write("Carácter: ");
            car2 = (int)Console.Read();
            Console.WriteLine(car);

            //se moifico el tipo de datode variable de char a int


            Console.ReadKey();
        }
    }
}
