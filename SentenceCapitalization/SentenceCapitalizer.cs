using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceCapitalization
{
    /// <summary>
    /// Class to implement capitalizing a sentence.
    /// </summary>
    public class SentenceCapitalizer
    {
        /// <summary>
        /// Capitalizes the specified sentence.
        /// </summary>
        /// <param name="input">Sentence to capitalize.</param>
        /// <returns>Capitalized sentence.</returns>
        public string Capitalize(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input), "input cannot be null");
            }

            StringBuilder stringBuilder = new StringBuilder();
            bool foundSpace = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                {
                    foundSpace = true;
                    stringBuilder.Append(input[i]);
                }
                else
                {
                    if (foundSpace)
                    {
                        stringBuilder.Append(char.ToUpper(input[i]));
                        foundSpace = false;
                    }
                    else
                    {
                        stringBuilder.Append(input[i]);
                    }
                }
            }

            return stringBuilder.ToString();
        }
    }
}
