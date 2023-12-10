using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PomazDS.Sprint6.Task5.V17.Lib
{
    public class DataService : ISprint6Task5V17
    {
        public double[] LoadFromDataFile(string path)
        {
            int size = File.ReadAllLines(path).Count();
            double[] array = new double[size];
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < size; i++)
                {
                    if (sr.Peek() > -1)
                    {
                        array[i] = double.Parse(sr.ReadLine());
                    }
                }
            }
            array = array.Where(i => i < 0).ToArray();

            return array;
        }
    }
}
