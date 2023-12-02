using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.CherepanovVS.Sprint6.Task1.V5.Lib;

namespace Tyuiu.CherepanovVS.Sprint6.Task1.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();


        private void textBoxConclusionResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxresulttable_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-23-1 Черепанов Вячеслав Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxData.Text);
                int stopStep = Convert.ToInt32(textBoxData2.Text);
                string strLine;
                int lenth = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = new double[lenth];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxresulttable.Text = "";
                textBoxresulttable.AppendText("+----------+-----------+" + Environment.NewLine);
                textBoxresulttable.AppendText("|    X     |    f(x)   |" + Environment.NewLine);
                textBoxresulttable.AppendText("+----------+-----------+" + Environment.NewLine);
                for (int x = 0; x <= lenth-1; x++)
                {
                    strLine = String.Format("|{0,5:d}     |{1, 8:f2}   |", startStep, valueArray[x]);
                    textBoxresulttable.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxresulttable.AppendText("+----------+-----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введено неверное значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
