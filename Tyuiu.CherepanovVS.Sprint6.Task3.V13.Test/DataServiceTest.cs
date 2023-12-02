using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint6.Task3.V13.Lib;

namespace Tyuiu.CherepanovVS.Sprint6.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalck()
        {
            DataService ds = new DataService();
            int[,] example = { { -7, 34, -2, 25, 5 }, { -16, -12, 30, -3, 17 }, { 3, -15, 12, 5, -5 }, { 17, 22, -3, 32, -11 }, { 9, 28, 1, - 9, - 2 } };
            int[,] res = ds.Calculate(example);
            int [,] wait = { { -7,-15, -2, 25, 5 }, { -16, -12, 30, -3, 17 }, { 3, 22, 12, 5, -5 }, { 17, 28, -3, 32, -11 }, { 9, 34, 1, -9, -2 } };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
