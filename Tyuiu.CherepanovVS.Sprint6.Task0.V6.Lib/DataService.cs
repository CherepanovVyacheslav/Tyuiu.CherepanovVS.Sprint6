using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.CherepanovVS.Sprint6.Task0.V6.Lib
{
    public class DataService : ISprint6Task0V6
    {
        public double Calculate(int x)
        {
            double res = x/ Math.Pow((Math.Pow(x,2)+x),0.5);
            return Math.Round(res,3);
        }
    }
}
