using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exploradordefrases
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos = 0, opcion = 0, largo = 0, cta=0, cte=0, cti=0, cto=0, ctu=0, ctacar=0;
            string frase="", vocal="";
            char buslet;

            while (opcion != 4)
            {

                Console.Clear();

                Console.WriteLine("\nMENU");
                Console.WriteLine("\n1. Ingresar un frase");
                Console.WriteLine("2. Buscar una letra especifica y mostrar sus indices dentro de la frase");
                Console.WriteLine("3. Identidicar cual vocal se repite mas e indicar el numero de veces");
                Console.WriteLine("4. Salir");
                Console.WriteLine("\nIngrese la opcion que desea: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("FRASE:  ");
                        frase = Console.ReadLine();
                        largo = frase.Length;
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la letra a buscar: ");
                        buslet = Convert.ToChar(Console.ReadLine());
                        for (int i = 0; i < largo; i++)
                        {
                            if (frase[i] == buslet)
                            {
                                Console.WriteLine("El caracter " + "'" + buslet + "'" + " coincide en la posicion " + i);
                                ctacar++;
                            }
                            
                        }
                        if (ctacar == 0)
                            Console.WriteLine("\nEL CARACTER NO SE DIGITO");
                        Console.ReadKey();
                        break;
                    case 3:
                        for (int i = 0; i < largo; i++)
                        {
                            if (frase[i] == 'a' || frase[i] == 'A')
                                cta++;
                            else if (frase[i] == 'e' || frase[i] == 'E')
                                cte++;
                            else if (frase[i] == 'i' || frase[i] == 'I')
                                cti++;
                            else if (frase[i] == 'o' || frase[i] == 'O')
                                cto++;
                            else if (frase[i] == 'u' || frase[i] == 'U')
                                ctu++;
                        }


                        if (cta > cte && cta > cti && cta > cto && cta > ctu)
                            vocal = "La vocal 'A' se repite " + cta + " veces";
                        else if (cte > cta && cte > cti && cte > cto && cte > ctu)
                            vocal = "La vocal 'E' se repite " + cta + " veces";
                        else if (cti > cte && cti > cta && cti > cto && cti > ctu)
                            vocal = "La vocal 'I' se repite " + cta + " veces";
                        else if (cto > cte && cto > cti && cto > cta && cto > ctu)
                            vocal = "La vocal 'O' se repite " + cta + " veces";
                        else if (ctu > cte && ctu > cti && ctu > cto && ctu > cta)
                            vocal = "La vocal 'U' se repite " + cta + " veces";
                        else if (cta==0 && cte==0 && cti==0 && cto==0 && ctu==0)
                            vocal = "NO SE INGRESARON VOCALES EN LA FRASE";
                        

                        for (int k = pos; k <= Console.BufferWidth - vocal.Length; k=k+10)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(k, 0);
                            Console.Write(vocal.ToUpper());
                            Thread.Sleep(1000);
                        }   
                        break;
                    case 4:
                        break;
                }
            }

            
        }
    }
}
