using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.CherepanovVS.Sprint6.Task5.V7.Lib;

namespace Tyuiu.CherepanovVS.Sprint6.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ReadData()
        {
            string path = $@"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint6\Tyuiu.CherepanovVS.Sprint6.Task5.V7\bin\Debug\Sprint6Task4\InPutFileTask5V7.txt";
            FileInfo file = new FileInfo(path);
            bool res = file.Exists;
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
