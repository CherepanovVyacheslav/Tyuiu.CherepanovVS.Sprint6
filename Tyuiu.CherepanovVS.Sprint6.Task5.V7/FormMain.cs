using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.CherepanovVS.Sprint6.Task5.V7.Lib;

namespace Tyuiu.CherepanovVS.Sprint6.Task5.V7
{
    public partial class FormMain_CVS : Form
    {
        public FormMain_CVS()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"C:\Users\Вячеслав\source\repos\Tyuiu.CherepanovVS.Sprint6\Tyuiu.CherepanovVS.Sprint6.Task5.V7\bin\Debug\Sprint6Task4\InPutFileTask5V7.txt";


        private void FormMain_CVS_Load(object sender, EventArgs e)
        {

        }

        private void buttonResult_CVS_Click(object sender, EventArgs e)
        {
            dataGridViewNums_CVS.ColumnCount = 2;
            dataGridViewNums_CVS.Columns[0].Width = 20;
            dataGridViewNums_CVS.Columns[1].Width = 50;
            this.chartGraf_CVS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGraf_CVS.ChartAreas[0].AxisY.Title = "Ось Y";
            chartGraf_CVS.Series[0].Points.Clear();
            double[] massive = new double[ds.len];
            massive = ds.LoadFromDataFile(path);
            for (int i = 0; i < massive.Length; i++)
            {
                dataGridViewNums_CVS.Rows.Add(Convert.ToString(i), Convert.ToString(massive[i]));
                chartGraf_CVS.Series[0].Points.AddXY(i, massive[i]);
            }


        }

        private void buttonOpenFile_CVS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInfo_CVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПКТб-23-1 Черепанов Вячеслав Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
