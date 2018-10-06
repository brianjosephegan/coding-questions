using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    /// <summary>
    /// Class to generate the Fibonacci series.
    /// </summary>
    public class FibonacciGenerator
    {
        /// <summary>
        /// Computes the result of summing the Fibonacci series up to the specified number.
        /// </summary>
        /// <param name="number">Highest number of Fibonacci series to sum.</param>
        /// <returns>Sum of the specified number of numbers in Fibonacci series.</returns>
        public int Generate(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("number cannot be negative", nameof(number));
            }
            else if (number == 0)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else if (results[number] != 0)
            {
                return results[number];
            }
            else
            {
                results[number] = (Generate(number - 2) + Generate(number - 1));
                return results[number];
            }
        }

        private readonly int[] results = new int[1000];
    }
}
