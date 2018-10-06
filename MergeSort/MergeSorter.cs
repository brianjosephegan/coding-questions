using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    /// <summary>
    /// Class to sort integers using Merge Sort algorithm.
    /// </summary>
    public class MergeSorter
    {
        /// <summary>
        /// Sorts the specified array of integers using Merge Sort algorithm.
        /// </summary>
        /// <param name="numbers">Array of integers to sort.</param>
        /// <returns>Sorted array of integers.</returns>
        public int[] Sort(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers), "numbers cannot be null");
            }

            if (!numbers.Any())
            {
                return numbers;
            }

            return MergeSort(numbers);
        }

        /// <summary>
        /// Sorts the specified array of integers by recursively splitting and merging the specified array.
        /// </summary>
        /// <param name="numbers">Array of integers to sort.</param>
        /// <returns>Sorted array of integers.</returns>
        private int[] MergeSort(int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return numbers;
            }

            List<int> numbersList = numbers.ToList();
            int centre = numbers.Length / 2;
            int[] left = numbersList.GetRange(0, centre).ToArray();
            int[] right = numbersList.GetRange(centre, numbers.Length % 2 == 0 ? centre : centre + 1).ToArray();

            return Merge(MergeSort(left), MergeSort(right));
        }

        /// <summary>
        /// Merges and sorts the specified integer arrays by choosing the largest value from each array every time.
        /// </summary>
        /// <param name="left">Left integer array to merge.</param>
        /// <param name="right">Right integer array to merge.</param>
        /// <returns>Sorted integer array</returns>
        private int[] Merge(int[] left, int[] right)
        {
            List<int> results = new List<int>();
            int leftIndex = 0;
            int rightIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if (left[leftIndex] < right[rightIndex])
                {
                    results.Add(left[leftIndex++]);
                }
                else
                {
                    results.Add(right[rightIndex++]);
                }
            }

            while (leftIndex < left.Length)
            {
                results.Add(left[leftIndex++]);
            }

            while (rightIndex < right.Length)
            {
                results.Add(right[rightIndex++]);
            }

            return results.ToArray();
        }
    }
}
