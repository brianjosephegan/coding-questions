using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrices
{
    /// <summary>
    /// Class to generate the a spiral matrix.
    /// </summary>
    public class SpiralMatrixGenerator
    {
        /// <summary>
        /// Generates the spiral matrix with the given number of rows and columns.
        /// </summary>
        /// <param name="number">Number of rows and columns to generate in the matrix.</param>
        /// <returns>Spiral matrix.</returns>
        public int[][] Generate(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("number cannot be negative", nameof(number));
            }

            int[][] results = new int[number][];
            for (int i = 0; i < results.Length; i++)
            {
                results[i] = new int[number];
            }
            int counter = 1;
            int columnIndex = 0;
            int rowIndex = 0;
            Direction current = Direction.Right;
            while (counter != (number * number) + 1)
            {
                switch (current)
                {
                    case Direction.Right:
                        {
                            while (true)
                            {
                                results[rowIndex][columnIndex] = counter++;
                                if (columnIndex + 1 >= number)
                                {
                                    break;
                                }
                                else if (columnIndex + 1 < number && results[rowIndex][columnIndex + 1] != 0)
                                {
                                    break;
                                }
                                else
                                {

                                    columnIndex++;
                                }
                            }
                            break;
                        }
                    case Direction.Down:
                        {
                            while (true)
                            {
                                results[rowIndex][columnIndex] = counter++;
                                if (rowIndex + 1 >= number)
                                {
                                    break;
                                }
                                else if (rowIndex + 1 < number && results[rowIndex + 1][columnIndex] != 0)
                                {
                                    break;
                                }
                                else
                                {
                                    rowIndex++;
                                }
                            }
                            break;
                        }
                    case Direction.Left:
                        {
                            while (true)
                            {
                                results[rowIndex][columnIndex] = counter++;
                                if (columnIndex - 1 < 0)
                                {
                                    break;
                                }
                                else if (columnIndex - 1 >= 0 && results[rowIndex][columnIndex - 1] != 0)
                                {
                                    break;
                                }
                                else
                                {
                                    columnIndex--;
                                }
                            }
                            break;
                        }
                    case Direction.Up:
                        {
                            while (true)
                            {
                                results[rowIndex][columnIndex] = counter++;
                                if (rowIndex - 1 < 0)
                                {
                                    break;
                                }
                                else if (rowIndex - 1 >= 0 && results[rowIndex - 1][columnIndex] != 0)
                                {
                                    break;
                                }
                                else
                                {
                                    rowIndex--;
                                }
                            }
                            break;
                        }
                    default:
                        {
                            throw new InvalidOperationException("Invalid direction encountered.");
                        }
                }

                current = Transition(current, ref rowIndex, ref columnIndex);
            }
            return results;
        }

        /// <summary>
        /// Switches direction.
        /// </summary>
        /// <param name="current">Current direction.</param>
        /// <param name="rowIndex">Current row index.</param>
        /// <param name="columnIndex">Current column index.</param>
        /// <returns>New direction.</returns>
        private Direction Transition(Direction current, ref int rowIndex, ref int columnIndex)
        {
            switch (current)
            {
                case Direction.Left:
                    {
                        rowIndex--;
                        return Direction.Up;
                    }
                case Direction.Right:
                    {
                        rowIndex++;
                        return Direction.Down;
                    }
                case Direction.Up:
                    {
                        columnIndex++;
                        return Direction.Right;
                    }
                case Direction.Down:
                    {
                        columnIndex--;
                        return Direction.Left;
                    }
                default:
                    {
                        throw new InvalidOperationException(string.Format("No transition available for {0}", current));
                    }
            }
        }

        /// <summary>
        /// Directions enumeration.
        /// </summary>
        private enum Direction
        {
            /// <summary>
            /// Left direction.
            /// </summary>
            Left,

            /// <summary>
            /// Right direction.
            /// </summary>
            Right,

            /// <summary>
            /// Up direction.
            /// </summary>
            Up,

            /// <summary>
            /// Down direction.
            /// </summary>
            Down
        }
    }
}
