using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    /// <summary>
    /// Class to implement the logic for a game of Fizz Buzz.
    /// </summary>
    public class FizzBuzz
    {
        /// <summary>
        /// Prints a game of Fizz Buzz up to the specified number of lines.
        /// </summary>
        /// <param name="number">Number of lines to print.</param>
        public void Print(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("number cannot be less than or equal to zero", nameof(number));
            }

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
