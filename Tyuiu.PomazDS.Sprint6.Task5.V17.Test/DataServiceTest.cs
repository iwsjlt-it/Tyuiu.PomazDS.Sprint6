using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint6.Task5.V17.Lib;

namespace Tyuiu.PomazDS.Sprint6.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
           
            double[] resultArray = {-17,-14.32,-7.84,-1.57,-3.64,-13.26,-8.91,-17.77,-9,-1.49,-7};
            string path = $@"C:\Users\admin\source\repos\Tyuiu.PomazDS.Sprint6\Tyuiu.PomazDS.Sprint6.Task5.V17\bin\Debug\InPutFileTask5V17.txt";
            double[] array = ds.LoadFromDataFile(path);

            CollectionAssert.AreEqual(array, resultArray);
        }
    }
}
