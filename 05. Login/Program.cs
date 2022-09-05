using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pass = Console.ReadLine();
            string reInput = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reInput += input[i];
            }
            
            int counter = 0;
            if (pass == reInput)
            {
                Console.WriteLine($"User {input} logged in.");

            }
            else
            {
                while (pass != reInput)
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                    counter++;
                    if (counter > 4)
                    {
                        Console.WriteLine($"User {input} blocked!");
                        break;
                    }
                    input = Console.ReadLine();
                    


                }
            }

            
            
            
        }
    }
}
