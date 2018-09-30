using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    /// <summary>
    /// Class to detect an anagram.
    /// </summary>
    public class AnagramDetector
    {
        /// <summary>
        /// Detects if the two specified strings are anagrams of each other. 
        /// </summary>
        /// <param name="input">String to check if it is an anagram.</param>
        /// <param name="otherInput">Other string to check if it is an anagram.</param>
        /// <returns>True if strings are anagrams of each other; false otherwise.</returns>
        public bool AreAnagrams(string input, string otherInput)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input), "input cannot be null or empty");
            }

            if (string.IsNullOrEmpty(otherInput))
            {
                throw new ArgumentNullException(nameof(otherInput), "otherInput cannot be null or empty");
            }

            return CharacterMapEquals(BuildCharacterMap(input.ToLower()), BuildCharacterMap(otherInput.ToLower()));
        }

        /// <summary>
        /// Builds a character map from the given string.
        /// </summary>
        /// <param name="input">String to build character map for.</param>
        /// <returns>Character map for the given string.</returns>
        private Dictionary<char, int> BuildCharacterMap(string input)
        {
            Dictionary<char, int> charMap = new Dictionary<char, int>();

            foreach (char character in input)
            {
                if (!char.IsWhiteSpace(character))
                {
                    if (charMap.ContainsKey(character))
                    {
                        charMap[character]++;
                    }
                    else
                    {
                        charMap[character] = 1;
                    }
                }
            }

            return charMap;
        }

        /// <summary>
        /// Determines whether the two given character maps are the same.
        /// </summary>
        /// <param name="map">A character map</param>
        /// <param name="otherMap">Another character map</param>
        /// <returns>True if character maps are equal; false otherwise.</returns>
        private bool CharacterMapEquals(Dictionary<char, int> map, Dictionary<char, int> otherMap)
        {
            return map.Count == otherMap.Count && !map.Except(otherMap).Any();
        }
    }
}
