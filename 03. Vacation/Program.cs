using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double priceForOne = 0;
            double discount = 0;
            double total = 0;

            switch (typeOfGroup)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            priceForOne = 8.45;
                            break;
                        case "Saturday":
                            priceForOne = 9.8;
                            break;
                        case "Sunday":
                            priceForOne = 10.46;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            priceForOne = 10.9;
                            break;
                        case "Saturday":
                            priceForOne = 15.6;
                            break;
                        case "Sunday":
                            priceForOne = 16;
                            break;

                        default:
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            priceForOne = 15;
                            break;
                        case "Saturday":
                            priceForOne = 20;
                            break;
                        case "Sunday":
                            priceForOne = 22.5;
                            break;

                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            total = priceForOne * countOfPeople;

            if (typeOfGroup == "Students" && countOfPeople >= 30)
            {
                total = priceForOne * countOfPeople;
                total = total - total * 0.15;
            }
            if (typeOfGroup == "Business" && countOfPeople >= 100)
            {
                countOfPeople = countOfPeople - 10;
                total = countOfPeople * priceForOne;
            }
            if (typeOfGroup == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                total = priceForOne * countOfPeople;
                total = total - total * 0.05;
            }

            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
