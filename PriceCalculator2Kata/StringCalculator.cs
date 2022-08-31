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
            string[] nums;
            if (numbers.StartsWith("//"))
            {
                numbers = numbers.Remove(0, 2).Trim(); // remove //
                char del;
                if (char.IsDigit(numbers[0]))
                    del = ' ';
                else
                   del = numbers.ElementAt(0);

                nums = numbers.Split(new Char[] { ',', '\n', del, ' '}); // split the string on different delimiters
            }
            else
            {
                nums = numbers.Split(new Char[] { ',', '\n' });
            }

            if (String.IsNullOrEmpty(numbers))
                return sum;

            foreach (var item in nums)
            {
                if (item == "")
                    nums[Array.IndexOf(nums, item)] = "0";
            }

                foreach (var item in nums)
                {

                    if (int.Parse(item) < 0)
                        negatives.Add(int.Parse(item));
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