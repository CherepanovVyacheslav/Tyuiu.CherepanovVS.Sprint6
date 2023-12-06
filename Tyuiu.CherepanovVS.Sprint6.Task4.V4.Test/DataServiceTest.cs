using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint6.Task4.V4.Lib;

namespace Tyuiu.CherepanovVS.Sprint6.Task4.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalck()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValur = 5;
            double [] res = ds.GetMassFunction(startValue,stopValur);
            double[] wait = {-2.15, -2.57, -3, -3.83, -11.7, 3, 2.19, 3.31, 2.97, 1.18, 0.03 };
            CollectionAssert.AreEqual(res,wait);



        }
    }
}
