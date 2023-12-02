using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint6.Task0.V7.Lib;

namespace Tyuiu.PomazDS.Sprint6.Task0.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 3;
            double result = ds.Calculate(x);
            Assert.AreEqual(0.211, result);
        }
    }
}
