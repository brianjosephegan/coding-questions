using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReversal
{
    public class StringReverser
    {
        public string Reverse(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input cannot be null", nameof(input));
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(input[i]);
            }

            return stringBuilder.ToString();
        }
    }
}
