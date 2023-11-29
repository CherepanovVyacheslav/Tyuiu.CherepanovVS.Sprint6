using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.CherepanovVS.Sprint6.Task1.V5.Lib
{
    public class DataService : ISprint6Task1V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            
            int lenth = stopValue - startValue + 1;
            double[] result = new double[lenth];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double res = Math.Round((Math.Sin(x) + (Math.Cos(2 * x) / 2) - 1.5 * x),2);
                result[count] = res;
                count++;
            }
            return (result);
        }
    }
}
