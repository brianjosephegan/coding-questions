using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingSteps
{
    /// <summary>
    /// Class to print out steps.
    /// </summary>
    public class StepPrinter
    {
        /// <summary>
        /// Prints the specified number of steps.
        /// </summary>
        /// <param name="number">Number of steps to print.</param>
        public void Print(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("number cannot be negative", nameof(number));
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= number; j++)
                {
                    if (j <= i)
                    {
                        stringBuilder.Append("#");
                    }
                    else
                    {
                        stringBuilder.Append(" ");
                    }
                }
                stringBuilder.AppendLine();
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
