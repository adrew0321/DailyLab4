using System;

namespace LabNumber4
{
    class Program
    {
        static void Main(string[] args)
        {


            //This programs displays a table of Powers

            Console.WriteLine($"Learn your squares and cubes!");
            Console.ReadLine();

            Console.Write($"Enter an integer: ");
            int userInput = int.Parse(Console.ReadLine());
            Console.ReadLine();

            String header = $"{"Number",-10} {"Squared",-11} {"Cubed",-10}";
            String divider = $"{"_______",-10} {"_______",-10} {"_______",-10}";

            Console.WriteLine($"{header}\n{divider}");


            for (int i = 1; i <= userInput; i++)
            {
                Console.WriteLine($"{i,-10} {i * i,-10} {i * i * i,-10}");
            }

        }



    }
}
