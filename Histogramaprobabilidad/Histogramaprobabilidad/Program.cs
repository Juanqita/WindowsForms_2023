using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Histogramaprobabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de datos: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 1;

            int[] datos = new int[n];

            Console.WriteLine("\n");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nIngrese el " + x + "° dato: ");
                datos[i] = Convert.ToInt32(Console.ReadLine());
                x++;
            }
            Console.Clear();

            Console.WriteLine();


            double promedio = CalcularPromedio(datos);
            Console.WriteLine("\nEl promedio de los datos es: " + promedio);
            Console.WriteLine("\n");

            Console.WriteLine("\nHISTOGRAMA DE PROBABILIDAD");

            int[] frecuencias = CalcularFrecuencias(datos);
            double[] probabilidades = CalcularProbabilidades(frecuencias, n);

            int maxFrecuencia = frecuencias.Max();

            

            for (int i = maxFrecuencia; i > 0; i--)
            {
                for (int j = 0; j < frecuencias.Length; j++)
                {
                    if (frecuencias[j] >= i)
                        Console.Write("*\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < frecuencias.Length; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            int centro = frecuencias.Length / 2;
            if (Math.Abs(promedio - centro) <= 1)
            {
                Console.WriteLine("\nEL PROMEDIO ESTA EN LA SEGUNDA VECINDAD DEL CENTRO");
            }
            else
            {
                Console.WriteLine("\nEL PROMEDIO NO ESTA EN LA SEGUNDA VECINDAD DEL CENTRO");
            }
            Console.ReadKey();

        }

        static double CalcularPromedio(int[] datos)
        {
            int suma = 0;
            foreach (int dato in datos)
            {
                suma += dato;
            }

            return (double)suma / datos.Length;
        }

        static int[] CalcularFrecuencias(int[] datos)
        {
            int maxValor = datos[0];
            foreach (int dato in datos)
            {
                if (dato > maxValor)
                    maxValor = dato;
            }

            int[] frecuencias = new int[maxValor + 1];

            foreach (int dato in datos)
            {
                frecuencias[dato]++;
            }

            return frecuencias;
        }

        static double[] CalcularProbabilidades(int[] frecuencias, int n)
        {
            double[] probabilidades = new double[frecuencias.Length];

            for (int i = 0; i < frecuencias.Length; i++)
            {
                probabilidades[i] = (double)frecuencias[i] / n;
            }

            return probabilidades;
    }
        }
 
   }
