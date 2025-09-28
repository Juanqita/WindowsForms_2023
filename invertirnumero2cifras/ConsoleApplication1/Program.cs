using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, dig1, dig2, numinv;

            Console.WriteLine("\nINVERTIR UN NUMERO DE DOS CIFRAS");
            Console.WriteLine("\nIngrese el numero a invertir: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 9 && num <100 )
            {
                dig1 = num / 10;
                dig2 = num % 10;
                numinv = dig2 * 10 + dig1;
                Console.WriteLine("Numero invertido: " + numinv);
            }
            else
                Console.WriteLine("EL NUMERO INGRESADO NO ES DE DOS CIFRAS");
            Console.ReadKey();
        }

    }
}
