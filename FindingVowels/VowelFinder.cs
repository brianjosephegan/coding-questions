using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingVowels
{
    /// <summary>
    /// Class to find the number of vowels in a string.
    /// </summary>
    public class VowelFinder
    {
        /// <summary>
        /// Find the number of vowels in the specified string.
        /// </summary>
        /// <param name="input">String to find number of vowels in.</param>
        /// <returns>Number of vowels in the string.</returns>
        public int Find(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "input cannot be null");
            }

            int result = 0;
            foreach (char character in input)
            {
                switch (char.ToLower(character))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        {
                            result++;
                            break;
                        }
                    default:
                        {
                            continue;
                        }
                }
            }
            return result;
        }
    }
}
