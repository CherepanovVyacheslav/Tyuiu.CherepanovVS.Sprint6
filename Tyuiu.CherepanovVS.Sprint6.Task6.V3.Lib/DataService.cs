using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.CherepanovVS.Sprint6.Task6.V3.Lib
{
    public class DataService : ISprint6Task6V3
    {
        public string CollectTextFromFile(string str, string path)
        {
            string k = " ";
            string resSTR = "";
            using (StreamReader elem = new StreamReader(path))
            {
                string line;
                while ((line = elem.ReadLine()) != null)
                {
                   
                    if (line.Contains(str))
                    {

                        resSTR+= " " + line;
                    }
                }
            }
            return resSTR;
        }
    }
}
