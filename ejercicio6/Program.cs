using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    public class Program
    {
        static void Main(string[] args)
        {
           
          int car1 = 'A', car2 = 65, car3 = 0;

          car3 = car1 + 'a' - 'A';
          Console.WriteLine((char)car3 + " " + car3);
          
          car3 = car2 + 32;
          Console.WriteLine((char)car3 + " " + car3);
          

         Console.ReadLine();

        // EL resultado que nos proporciona es a = 97
        //ya un resultado direfente porque la variable sele asigna un valor espesifico

        }
        
    }
}
