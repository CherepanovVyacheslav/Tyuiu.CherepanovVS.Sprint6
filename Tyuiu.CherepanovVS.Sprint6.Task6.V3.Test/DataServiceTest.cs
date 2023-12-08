using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.CherepanovVS.Sprint6.Task6.V3.Lib;

namespace Tyuiu.CherepanovVS.Sprint6.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Checkfile()
        {
            string path = $@"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint6\Tyuiu.CherepanovVS.Sprint6.Task6.V3\bin\Debug\Sprint6Task6\InPutFileTask6V3.txt";
            FileInfo file = new FileInfo(path);
            bool res = file.Exists;
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
