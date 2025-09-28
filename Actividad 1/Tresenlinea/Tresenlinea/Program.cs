using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tresenlinea
{
    class Program
    {
        static void Main(string[] args)
        {
            int cta = 0, pos = 0;
            int ctx = 0, cto = 0;
            string figx = "X", figo = "O";
            string[,] tablero = new string[5, 5];
            bool[,] posocu = new bool[5, 5];
            bool turnoO = true, terminar = false;

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("                                                REFERENCIA");
            Console.WriteLine("                                                (Empieza O)");
            Console.WriteLine("                                              1     2     3");
            Console.WriteLine("                                              4     5     6");
            Console.WriteLine("                                              7     8     9");
            Console.WriteLine("\n");

            for (int i = 0; i <= 2; i++)
            {
                Console.Write("                                             ");
                for (int j = 0; j <= 2; j++)
                {
                    tablero[i, j] = Convert.ToString("-");
                    Console.Write(tablero[i, j]);
                    Console.Write("      ");
                }
                Console.WriteLine("\n");
            }

            while (cta < 9 && terminar == false)
            {
                Console.Write("                                         Ingrese la posición a jugar: ");
                pos = Convert.ToInt32(Console.ReadLine());

                if (pos == 0)
                {

                }
                
                else if (pos > 1 || pos < 10)
                {
                    int fila = (pos - 1) / 3;
                    int columna = (pos - 1) % 3;
               

                    if (!posocu[fila, columna])
                    {
                        string fig = turnoO ? figo : figx;
                        int stat = turnoO ? cto : ctx;
                        tablero[fila, columna] = fig;
                        posocu[fila, columna] = true;
                        cta++;
                        turnoO = !turnoO;

                    }
                    Console.Clear();

                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("                                                REFERENCIA");
                    Console.WriteLine("                                                (Empieza O)");
                    Console.WriteLine("                                              1     2     3");
                    Console.WriteLine("                                              4     5     6");
                    Console.WriteLine("                                              7     8     9");
                    Console.WriteLine("\n");

                    for (int i = 0; i <= 2; i++)
                    {
                        Console.Write("                                             ");
                        for (int j = 0; j <= 2; j++)
                        {
                            Console.Write(tablero[i, j]);
                            Console.Write("      ");
                        }
                        Console.WriteLine("\n");
                    }
 
                }

                if (tablero[0, 0] == tablero[0, 1] && tablero[0, 0] == tablero[0, 2] && tablero[0, 0] != "-")
                {
                    Console.WriteLine("\n                                               ¡ " + tablero[0, 0] + "  GANA !");
                    terminar = true;
                }
                else if (tablero[1, 0] == tablero[1, 1] && tablero[1, 0] == tablero[1, 2] && tablero[1, 0] != "-")
                {
                    Console.WriteLine("\n                                               ¡ " + tablero[1, 0] + "  GANA !");
                    terminar = true;
                }
                else if (tablero[2, 0] == tablero[2, 1] && tablero[2, 0] == tablero[2, 2] && tablero[2, 0] != "-")
                {
                    Console.WriteLine("\n                                               ¡ " + tablero[2, 0] + "  GANA !");
                    terminar = true;
                }

                else if (tablero[0, 0] == tablero[1, 0] && tablero[0, 0] == tablero[2, 0] && tablero[0, 0] != "-")
                {
                    Console.WriteLine("\n                                               ¡ " + tablero[0, 0] + "  GANA !");
                    terminar = true;
                }
                else if (tablero[0, 1] == tablero[1, 1] && tablero[0, 1] == tablero[2, 1] && tablero[0, 1] != "-")
                {
                    Console.WriteLine("\n                                               ¡ " + tablero[0, 1] + "  GANA !");
                    terminar = true;
                }
                else if (tablero[0, 2] == tablero[1, 2] && tablero[0, 2] == tablero[2, 2] && tablero[0, 2] != "-")
                {
                    Console.WriteLine("\n                                               ¡ " + tablero[0, 2] + "  GANA !");
                    terminar = true;
                }

                else if (tablero[0, 0] == tablero[1, 1] && tablero[0, 0] == tablero[2, 2] && tablero[0, 0] != "-")
                {
                    Console.WriteLine("\n                                               ¡ " + tablero[0, 0] + "  GANA !");
                    terminar = true;
                }
                else if (tablero[0, 2] == tablero[1, 1] && tablero[0, 2] == tablero[2, 0] && tablero[0, 2] != "-")
                {
                    Console.WriteLine("\n                                               ¡ " + tablero[0, 2] + "  GANA !");
                    terminar = true;
                }
            }

            Console.ReadLine();

        }
        
    }
}
