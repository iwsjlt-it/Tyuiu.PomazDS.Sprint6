using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PomazDS.Sprint6.Task0.V7.Lib
{
    public class DataService : ISprint6Task0V7
    {
        public double Calculate(int x)
        {
            double result = Math.Round(Math.Pow(x, 3) / (2 * Math.Pow(x + 5, 2)), 3);
            return result;
        }
    }
}
