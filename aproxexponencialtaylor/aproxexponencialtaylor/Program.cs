using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aproxexponencialtaylor
{
    class Program
    {
        static void Main(string[] args)
        {
            int orden = 0, facto=1;

            Console.WriteLine("\nAPROXIMACION EN SERIES DE TAYLOR DE LA FUNCION EXPONENCIAL");
            Console.WriteLine("\nDefina el orden de aproximacion: ");
            orden = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n e ^ x = 1 + X + ");
            for (int i = 2; i <= orden; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    facto = facto * j;
                }
                    Console.Write("X^" + i + "/" + i+"!" + " + ");
                if (i == 0)
                    Console.Write(1 + "+");
            }
            Console.Write("...");
            Console.ReadKey();
        }
    }
}
