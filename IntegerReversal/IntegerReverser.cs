using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerReversal
{
    /// <summary>
    /// Class to reverse a string.
    /// </summary>
    public class IntegerReverser
    {
        /// <summary>
        /// Reverses the specified integer.
        /// </summary>
        /// <param name="number">Integer to reverse.</param>
        /// <returns>The reversed integer.</returns>
        public int Reverse(int number)
        {
            int reversed = 0;
            int tenMultiple = number.ToString().Length - 1;
            bool negate = number < 0;
            if (negate)
            {
                tenMultiple--;
                number *= -1;
            }

            while (number != 0)
            {
                reversed += (int)Math.Pow(10, tenMultiple) * (number % 10);
                tenMultiple--;
                number /= 10;
            }

            return negate ? reversed * -1 : reversed;
        }
    }
}
