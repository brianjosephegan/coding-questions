using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    public class AnagramDetector
    {
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

        private bool CharacterMapEquals(Dictionary<char, int> map, Dictionary<char, int> otherMap)
        {
            return map.Count == otherMap.Count && !map.Except(otherMap).Any();
        }
    }
}
