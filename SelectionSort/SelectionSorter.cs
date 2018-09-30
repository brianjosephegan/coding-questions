using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    /// <summary>
    /// Class to sort integers using Selection Sort algorithm.
    /// </summary>
    public class SelectionSorter
    {
        /// <summary>
        /// Sorts the specified array of integers using Selection Sort algorithm.
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
                int minIndex = i;

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[minIndex] > numbers[j])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    numbers[i] ^= numbers[minIndex];
                    numbers[minIndex] ^= numbers[i];
                    numbers[i] ^= numbers[minIndex];
                }
            }

            return numbers;
        }
    }
}
