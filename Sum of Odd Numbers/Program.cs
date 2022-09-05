using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int numbers = 1;

            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(numbers);
                sum += numbers;
                numbers += 2;
                
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
