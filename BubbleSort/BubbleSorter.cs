using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    /// <summary>
    /// Class to sort integers using Bubble Sort algorithm.
    /// </summary>
    public class BubbleSorter
    {
        /// <summary>
        /// Sorts the specified array of integers using Bubble Sort algorithm.
        /// </summary>
        /// <param name="numbers">Array of integers to sort.</param>
        /// <returns>Sorted array of integers.</returns>
        public int[] Sort(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers), "numbers cannot be null");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        numbers[j] ^= numbers[j + 1];
                        numbers[j + 1] ^= numbers[j];
                        numbers[j] ^= numbers[j + 1];
                    }
                }
            }

            return numbers;
        }
    }
}
