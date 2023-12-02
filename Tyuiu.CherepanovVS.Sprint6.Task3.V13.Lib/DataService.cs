using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.CherepanovVS.Sprint6.Task3.V13.Lib
{
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {

            int[] kal = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                kal[i] = matrix[i, 1];
            }
            Array.Sort(kal);

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[i, 1] = kal[i];
            }
            return matrix;
        }
    }
}
