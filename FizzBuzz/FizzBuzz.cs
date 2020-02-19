using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        private string TransformeNumber(int number)
        {
            string result = null;
            if (number % 3 == 0)
                result = "Fizz";
            if (number % 5 == 0)
                result += "Buzz";

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }

        public string EvaluateNumbers(int min, int? max = null)
        {
            string result = TransformeNumber(min);
            if (max.HasValue)
            {
                if (max < min)
                    throw new ArgumentOutOfRangeException();

                while (min++ < max)
                {
                    result += TransformeNumber(min);
                }
            }

            return result;
        }
    }
}
