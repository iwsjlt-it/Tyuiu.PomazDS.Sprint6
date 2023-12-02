using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PomazDS.Sprint6.Task1.V2.Lib
{
    public class DataService : ISprint6Task1V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array = new double[-startValue + stopValue+1];
            for (int i = 0, x = startValue; x <= stopValue; x++, i++)
            {
                array[i] = Math.Round(((5.0 * x + 2.5) / (Math.Sin(x) + 2.0)) + 2.0 * x + 2.0,2);
            }

            return array;
        }
    }

}
