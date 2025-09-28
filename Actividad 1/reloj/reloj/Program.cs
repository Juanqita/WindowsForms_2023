using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Text;

namespace reloj
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int hora = 0, rechora = 0, recminuto = 0, minuto = 0, opcion = 0, tiempoh = 0, tiempom = 0, distancia = 0;
            DateTime ahora=DateTime.Now, timbre=DateTime.Now;
            TimeSpan time;
            Timer timer = new Timer();

            Console.WriteLine("\n");
            Console.WriteLine("MENU\n");
            Console.WriteLine("1. Ingresar la hora actual");
            Console.WriteLine("2. Programar un recordatorio");
            Console.WriteLine("3. Ver la hora actual (configurada previamente)");
            Console.WriteLine("4. Salir");
            Console.WriteLine("\n");
            Console.Write("Ingrese la opcion que desea: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            while (opcion != 4)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("FORMATO DE RELOJ: 12 HORAS\n");
                        Console.Write("(HORA ACTUAL): ");
                        hora = Convert.ToInt32(Console.ReadLine());
                        if (hora < 0 || hora >= 13)
                        {
                            Console.Write("¡¡¡INGRESE UNA HORA DE ACUERDO AL FORMATO 12H!!!");
                        }
                        else
                        {
                            Console.Write("\n(MINUTOS ACTUAL): ");
                            minuto = Convert.ToInt32(Console.ReadLine());
                            if (minuto < 0 || minuto >= 60)
                            {
                                Console.Write("¡¡¡UNA HORA TIENE DE O A 59 MINUTOS!!!");
                            }
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("MENU\n");
                            Console.WriteLine("1. Ingresar la hora actual");
                            Console.WriteLine("2. Programar un recordatorio");
                            Console.WriteLine("3. Ver la hora actual (configurada previamente)");
                            Console.WriteLine("4. Salir");
                            Console.WriteLine("\n");
                            Console.Write("Ingrese la opcion que desea: ");
                            opcion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                        }
                        DateTime Alarma1 = new DateTime(ahora.Year, ahora.Month, ahora.Day, hora, minuto, 0);
                        TimeSpan tiempo = Alarma1.TimeOfDay;
                        ahora = Alarma1;
                        break;
                    case 2:
                        Console.WriteLine("FORMATO DE RELOJ: 12 HORAS\n");
                        Console.Write("(HORA A RECORDAR): ");
                        rechora = Convert.ToInt32(Console.ReadLine());
                        if (rechora < 0 || rechora >= 13)
                        {
                            Console.Write("¡¡¡INGRESE UNA HORA DE ACUERDO AL FORMATO 12H!!!");
                        }
                        else
                        {
                            Console.Write("\n(MINUTOS A RECORDAR: ): ");
                            recminuto = Convert.ToInt32(Console.ReadLine());
                            if (recminuto < 0 || recminuto >= 60)
                            {
                                Console.Write("¡¡¡UNA HORA TIENE DE O A 59 MINUTOS!!!");
                            }
                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("MENU\n");
                            Console.WriteLine("1. Ingresar la hora actual");
                            Console.WriteLine("2. Programar un recordatorio");
                            Console.WriteLine("3. Ver la hora actual (configurada previamente)");
                            Console.WriteLine("4. Salir");
                            Console.WriteLine("\n");
                            Console.Write("Ingrese la opcion que desea: ");
                            opcion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");
                        }
                        
                        DateTime Alarma2 = new DateTime(timbre.Year, timbre.Month, timbre.Day, rechora, recminuto, 0);
                        TimeSpan tiempoalar = Alarma2.TimeOfDay;
                        timbre = Alarma2;
                        time = timbre - ahora;
                        tiempoh = (timbre.Hour - ahora.Hour) * 3600;
                        tiempom = (timbre.Minute - ahora.Minute) * 60;
                        distancia = tiempoh + tiempom;
                        timer = new Timer(distancia * 1000);
                        timer.Elapsed += TimerElapsed;
                        
                        
                        break;
                    case 3:

                        if (hora != 12)
                        {
                            if (minuto >= 0 && minuto <= 9)
                            {
                                Console.WriteLine("\nHORA ACTUAL:  0" + hora + ":0" + minuto);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("\nHORA ACTUAL:  0" + hora + ":" + minuto);
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            if (minuto >= 0 && minuto <= 9)
                            {
                                Console.WriteLine("\nHORA ACTUAL:  " + hora + ":0" + minuto);
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("\nHORA ACTUAL:  " + hora + ":" + minuto);
                                Console.ReadKey();
                            }
                        }

                            Console.Clear();
                            Console.WriteLine("\n");
                            Console.WriteLine("MENU\n");
                            Console.WriteLine("1. Ingresar la hora actual");
                            Console.WriteLine("2. Programar un recordatorio");
                            Console.WriteLine("3. Ver la hora actual (configurada previamente)");
                            Console.WriteLine("4. Salir");
                            Console.WriteLine("\n");
                            Console.Write("Ingrese la opcion que desea: ");
                            opcion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\n");

                        break;
                    case 4:
                        Console.ReadKey();
                        break;
                    default:
                        timer.AutoReset = false;
                        timer.Start();

                        break;


                    
                }


            }
        }
        static void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            System.Console.Beep(1000, 5000);
        }
    }
}
