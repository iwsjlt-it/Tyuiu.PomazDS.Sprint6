using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PomazDS.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {

            int[] sortMatrix = new int[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sortMatrix[i] = matrix[i, matrix.GetLength(1) - 1];
            }

            Array.Sort(sortMatrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i,4] = sortMatrix[i];
            }
            return matrix;
        }
    }
}
