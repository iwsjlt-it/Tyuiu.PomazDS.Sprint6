using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint6.Task1.V2.Lib;

namespace Tyuiu.PomazDS.Sprint6.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidArrayCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] array = new double[-startValue + stopValue + 1];
            array[0] = -15.6;
            array[1] = -12.35;
            array[2] = -10.72;
            array[3] = -8.88;
            array[4] = -2.16;
            array[5] = 3.25;
            array[6] = 6.64;
            array[7] = 10.3;
            array[8] = 16.17;
            array[9] = 28.1;
            array[10] = 38.41;

            double[] checkArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(checkArray, array);
         
        }
    }
}
