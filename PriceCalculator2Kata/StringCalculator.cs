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
            var negatives = new List<int>();
            string[] nums = numbers.Split(new Char[] { ',', '\n' });

            if (String.IsNullOrEmpty(numbers))
                return sum;

            foreach(var item in nums)
            {
                
                if (int.Parse(item)< 0)
                {
                    negatives.Add(int.Parse(item));
                }
            }

            foreach (var item in nums)
            {
                if (int.Parse(item) < 0)
                    throw new ArgumentException("Negatives Not Allowed" + negatives);
                
                if(!(int.Parse(item) > 1000))
                    sum += int.Parse(item);
            }

            return sum;
        }

    }
}