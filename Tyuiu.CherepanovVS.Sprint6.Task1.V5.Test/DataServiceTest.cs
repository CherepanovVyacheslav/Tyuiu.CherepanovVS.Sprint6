using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint6.Task1.V5.Lib;

namespace Tyuiu.CherepanovVS.Sprint6.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalck()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            double[] wait = { 8.04, 6.68, 4.84, 1.76, 0.45, 0.5, -0.87, -2.42, -3.88, -6.83, -8.88 };
            CollectionAssert.AreEqual(res, wait);


        }
    }
}
