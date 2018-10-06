using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxChars
{
    /// <summary>
    /// Class to find the character that occurs the most in a string.
    /// </summary>
    public class MaxCharFinder
    {
        /// <summary>
        /// Finds the character that occurs the most in the specified string.
        /// </summary>
        /// <param name="input">String to find the chracter that occurs the most in.</param>
        /// <returns>Character that appeared the most in the string.</returns>
        public char? Find(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input cannot be null", nameof(input));
            }

            char? max = null;
            Dictionary<char, int> characterMap = new Dictionary<char, int>();

            foreach (char character in input)
            {
                if (characterMap.ContainsKey(character))
                {
                    characterMap[character]++;
                    if (characterMap[max.Value] < characterMap[character])
                    {
                        max = character;
                    }
                }
                else
                {
                    characterMap.Add(character, 1);
                    if (max == null)
                    {
                        max = character;
                    }
                }
            }

            return max;
        }
    }
}
