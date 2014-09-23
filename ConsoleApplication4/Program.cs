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

            Console.Write("Ange antalet löner ");
            int NumberOfSalaries;
            NumberOfSalaries = int.Parse(Console.ReadLine());


            int[] theSalaries = new int[NumberOfSalaries];
            Console.Write("Ange en lön nummer {0} ", i);
            for (int i = 0; i < NumberOfSalaries; i++)
            {

                theSalaries[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(theSalaries);



            if (NumberOfSalaries % 2 == 0)
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




            for (int i = 1; i <= NumberOfSalaries; i++)
            {
                if (i % 3 != 0)
                {
                    Console.Write("{0,8}", theSalaries[i - 1]);
                }
                else
                {
                    Console.Write("{0,8}", theSalaries[i - 1]);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();





        }
    }
}
