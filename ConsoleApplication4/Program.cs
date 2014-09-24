using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSalaries;

            do
            {
                numberOfSalaries = ReadInt("Ange antalet löner: ");

                if (numberOfSalaries > 1)
                {
                    ProcessSalaries(numberOfSalaries);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Vänligen ange minst två löner");
                    Console.ResetColor();
                }
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n Tryck tangent för ny beräkning - Esc avslutar");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
           
        }

        static int ReadInt(string prompt)
        {
            //Hämtar info från användaren 
            string readTemp = null;
            
            do
            {
                Console.Write(prompt);
                try
                {
                    readTemp = Console.ReadLine();
                    return int.Parse(readTemp);
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel '{0}' är inte ett heltal", readTemp);
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fel '{0}' är ett för högt värde. Maxvärde är {1}", readTemp, int.MaxValue);
                    Console.ResetColor();
                }
            } while (true);
        }

        static void ProcessSalaries(int count) {

             int[] theSalaries = new int[count];
             int[] theSalariesCop = new int[count];

            for (int i = 0; i < count; i++)
            {
                theSalaries[i] = ReadInt(String.Format("Ange lön nummer  {0} :", i + 1) ); 
            }

            Console.WriteLine("\n-----------------------------");
            Array.Copy(theSalaries, theSalariesCop, count);
            Array.Sort(theSalaries);

            if (count % 2 == 0)
            {
                int medianPart1 = theSalaries[theSalaries.Length / 2];
                int medianPart2 = theSalaries[theSalaries.Length / 2 - 1];
                int medianEven = (medianPart1 + medianPart2) / 2;
                Console.WriteLine("Medianlönen: {0:c0}", medianEven);
            }
            else
            {
                int medianOdd = theSalaries[theSalaries.Length / 2];
                Console.WriteLine("Medianlönen: {0:c0}", medianOdd);
            }

            Console.WriteLine("Medelvärdet: {0:c0}", theSalaries.Average());

            int salarieSpread = theSalaries.Max() - theSalaries.Min();
            Console.WriteLine("Lönespridningen är:  {0:c0}", salarieSpread);

            Console.WriteLine("-----------------------------");


            for (int i = 1; i <= count; i++)
            {
                if (i % 3 != 0)
                {
                    Console.Write("{0,8}", theSalariesCop[i - 1]);
                }
                else
                {
                    Console.Write("{0,8}", theSalariesCop[i - 1]);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}
