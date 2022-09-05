using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());

            int product = 0;

            if (time <= 10)
            {

                for (int i = time; i <= 10; i++)
                {
                    product = theInteger * i;
                    Console.WriteLine($"{theInteger} X {i} = {product}");
                }
            }
            else
            {
                product = theInteger * time;
                Console.WriteLine($"{theInteger} X {time} = {product}");
                
            }

        }
    }
}
