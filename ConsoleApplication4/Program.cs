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





            int NumberOfSalaries;
            NumberOfSalaries = ReadInt("Ange antalet löner: ");

            if (NumberOfSalaries < 1)
            {

                ProcessSalaries(NumberOfSalaries);

            }
            else



        }

        static int ReadInt(string prompt)
        {
            
            int value = 0;
            string readTemp = null;

            
            do
            {
                Console.Write(prompt);
                try
                {
                    readTemp = Console.ReadLine();
                    value = int.Parse(readTemp);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Fel '{0}' är inte ett heltal", readTemp);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Fel '{0}' är ett för högt värde. Maxvärde är 2,147,483,647", readTemp);
                }
            } while (value < 1);

            
            return value;
        }

        static void ProcessSalaries(int count) {

            int[] theSalaries = new int[count];
             int[] theSalariesCop = new int[count];

            for (int i = 0; i < count; i++)
            {

                theSalaries[i] = ReadInt("Ange lön nummer  {0}:");

            }


            Console.WriteLine("\n-----------------------------");
            Array.Copy(theSalaries, theSalariesCop, count);
            Array.Sort(theSalaries);



            if (count % 2 == 0)
            {


                int medianPart1 = theSalaries[theSalaries.Length / 2];
                int medianPart2 = theSalaries[theSalaries.Length / 2 - 1];
                int medianEven = (medianPart1 + medianPart2) / 2;


                Console.WriteLine("Medianlönen: {0:c}", medianEven);
            }

            else
            {
                int medianOdd = theSalaries[theSalaries.Length / 2];
                Console.WriteLine("Medianlönen: {0:c}", medianOdd);
            }

            Console.WriteLine("Medelvärdet: {0:c}", theSalaries.Average());

            int salarieSpread = theSalaries.Max() - theSalaries.Min();
            Console.WriteLine("Lönespridningen är:  {0:c}", salarieSpread);

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
