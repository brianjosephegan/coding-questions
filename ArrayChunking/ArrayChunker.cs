using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayChunking
{
    /// <summary>
    /// Class to chunk an array.
    /// </summary>
    public class ArrayChunker
    {
        /// <summary>
        /// Breaks the specified array into separate arrays of the specified size.
        /// </summary>
        /// <param name="input">Array to chunk.</param>
        /// <param name="size">Size of a chunk.</param>
        /// <returns>The chunked array.</returns>
        public int[][] Chunk(int[] input, int size)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "input cannot be null");
            }

            if (!input.Any())
            {
                throw new ArgumentException("input cannot be empty", nameof(input));
            }

            if (size <= 0)
            {
                throw new ArgumentException("size cannot be less than or equal to zero", nameof(size));
            }

            List<int[]> results = new List<int[]>();
            List<int> result = new List<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (result.Count >= size)
                {
                    results.Add(result.ToArray());
                    result = new List<int>();
                }

                result.Add(input[i]);
            }
            results.Add(result.ToArray());
            return results.ToArray();
        }
    }
}
