using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    /// <summary>
    /// Class to detect a palindrome.
    /// </summary>
    public class PalindromeDetector
    {
        /// <summary>
        /// Detects if the specified string is a palindrome. 
        /// </summary>
        /// <param name="input">String to check if it is a palindrome.</param>
        /// <returns>True if string is a palindrome; false otherwise.</returns>
        public bool IsPalindrome(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input cannot be null", nameof(input));
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
