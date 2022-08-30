using System;

namespace PriceCalculator2Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "1,2,3,4";

            Console.WriteLine($"The sum is { StringCalculator.Add(temp)}");
        }
    }
}
