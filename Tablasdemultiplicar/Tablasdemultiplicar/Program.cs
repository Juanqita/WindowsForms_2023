using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tablasdemultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0, menor = 0, mayor = 0, tope = 0, diferencia = 0, multi = 0, suma = 0, lar = 0;
            while (opcion != 5)
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("\n1. Ingresar numero menor");
                Console.WriteLine("2. Ingresar numero mayor");
                Console.WriteLine("3. Ingresar el numero hasta el cual imprimir");
                Console.WriteLine("4. Mostrar tablas y promediar los resultados de la sumatoria de las tablas");
                Console.WriteLine("5. Salir");
                Console.WriteLine("\nIngrese la opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.Clear();

                switch (opcion)
                { 
                    case 1:
                        Console.WriteLine("Ingrese el menor numero a calcular: ");
                        menor = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el mayor numero a calcular: ");
                        mayor = Convert.ToInt32(Console.ReadLine());
                        diferencia = mayor - menor;
                        if (diferencia > 2)
                            Console.WriteLine("NO PUEDE HABER UNA DIFERENCIA DE MAS DE DOS UNIDADES ENTRE LOS LIMITES, INGRESE DE NUEVO");
                        else
                            mayor = mayor;
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el numero hasta el cual imprimir: ");
                        tope = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        for (int j = menor; j <= mayor; j++)
                        {
                            for (int i = -1; i <= tope; i++)
                            {
                                multi = j*i;
                                suma = suma + multi;
                                
                                Console.WriteLine(" \n" + j + " x " + i + " = " + multi);
                                if (multi == 24)
                                {
                                    break;
                                }
                                lar = i + 1;
                            }
                            if (suma / lar < 0)
                                Console.WriteLine("Promedio= " + (decimal)-1 * suma / lar);
                            else
                                Console.WriteLine("Promedio= " + (decimal)suma / lar);
                            Console.WriteLine("\n");

                        }
                        Console.ReadKey();
                            break;
                    case 5:
                            break;

                }
            }
            Console.ReadKey();

        }
    }
}
