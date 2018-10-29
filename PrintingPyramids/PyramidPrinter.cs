using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingPyramids
{
    /// <summary>
    /// Class to print out pyramids.
    /// </summary>
    public class PyramidPrinter
    {
        /// <summary>
        /// Prints out a pyramid with the specified number of layers.
        /// </summary>
        /// <param name="number">Number of layers to print.</param>
        public void Print(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("number cannot be negative", nameof(number));
            }

            StringBuilder stringBuilder = new StringBuilder();

            int numberSpacesPerSide = number - 1;
            int numberPoundsPerRow = 1;
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= numberSpacesPerSide; j++)
                {
                    stringBuilder.Append(" ");
                }
                for (int j = 1; j <= numberPoundsPerRow; j++)
                {
                    stringBuilder.Append("#");
                }
                for (int j = 1; j <= numberSpacesPerSide; j++)
                {
                    stringBuilder.Append(" ");
                }
                stringBuilder.AppendLine();

                numberPoundsPerRow += 2;
                numberSpacesPerSide -= 1;
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
