using System;

namespace LabNumber4
{
    class Program
    {
        static void Main(string[] args)
        {

            //This programs displays a table of Powers

            //***INPUT***
            bool repeat1 = true;
            while (repeat1)
            {
                int userInput = 0;

                Console.WriteLine($"Learn your squares and cubes!");
                Console.ReadLine();

                bool repeat2 = true;
                while(repeat2)
                {
                    Console.Write($"Enter an integer: ");

                        try
                        {
                            userInput = int.Parse(Console.ReadLine());
                            repeat2 = false;

                                if (userInput < 0)
                                {
                                    Console.WriteLine($"You've entered an invalid input. Please use a positive integer");
                                    repeat2 = true;
                                    break;
                                }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine($"Invalid Input: Please try again...");
                            repeat2 = true;
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine($"Invalid input: The integer you've entered is too large or too small. Please try again...");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Critical Error: {e.Message}");
                            repeat2 = false;
                        }
                
                    

                    
                }

                Console.ReadLine();

                //Processing
                String header = $"{"Number",-10} {"Squared",-11} {"Cubed",-10}";
                String divider = $"{"_______",-10} {"_______",-10} {"_______",-10}";

                Console.WriteLine($"{header}\n{divider}");

                for (int i = 1; i <= userInput; i++)
                {
                    Console.WriteLine($"{i,-10} {i * i,-10} {i * i * i,-10}");
                }

                //***OUTPUT***
                bool continueResponse = true;
                while (continueResponse)
                {
                    Console.WriteLine($"Continue? (y/n)");
                    string UserResponse = Console.ReadLine();

                    if (UserResponse.ToLower() == "y" || UserResponse.ToLower() == "yes")
                    {
                        repeat1 = true;
                        continueResponse = false;
                    }
                    else if (UserResponse.ToLower() == "n" || UserResponse.ToLower() == "no")
                    {
                        Console.WriteLine($"It's been a pleasure working with you. Until next time...Goodbye!");
                        repeat1 = false;
                        continueResponse = false;
                    }
                    else
                    {
                        Console.WriteLine($"You've entered an invalid input. Please try again...");
                        repeat1 = false;
                        continueResponse = true;
                    }


                }

            }



        }
    }
}
