using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PomazDS.Sprint6.Task7.V6.Lib
{
    public class DataService : ISprint6Task7V6
    {
        public int[,] GetMatrix(string path)
        {
            string str = File.ReadAllText(path);
            string[] strArray = str.Split(new char[] { ';', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[,] array = new int[File.ReadAllLines(path).Count(), File.ReadAllLines(path).Count()];
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = int.Parse(strArray[count]);
                    count++;
                }
            }
            return array;

        }
    }
}
