using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PomazDS.Sprint6.Task6.V13.Lib;

namespace Tyuiu.PomazDS.Sprint6.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = "C:\\Users\\admin\\Downloads\\Sprint6Task6\\Sprint6Task6\\InPutFileTask6V13.txt";

            string result = ds.CollectTextFromFile(path);
            Assert.AreEqual("WLCdQb\r\nehWGn\r\nMcJC\r\nlhTKeblSG\r\ndXbj", result);
        }
    }
}
