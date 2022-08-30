using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceCalculator2Kata
{
    public static class StringCalculator
    {

        public static int Add(String numbers)
        {
            int sum = 0;
            if (String.IsNullOrEmpty(numbers))
                return sum;

            string[] nums = numbers.Split(new Char[] { ',', '\n' });
            foreach (var item in nums)
                sum += int.Parse(item);

            return sum;
        }

    }
}