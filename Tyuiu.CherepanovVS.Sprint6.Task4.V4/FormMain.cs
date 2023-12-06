using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.CherepanovVS.Sprint6.Task4.V4.Lib;

namespace Tyuiu.CherepanovVS.Sprint6.Task4.V4
{
    public partial class FormMain_CVS : Form
    {
        public FormMain_CVS()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxProperty_CVS_Enter(object sender, EventArgs e)
        {

        }

        private void buttonResult_CVS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputData_CVS.Text);
                int stopStep = Convert.ToInt32(textBoxInputData2_CVS.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] massive = new double[len];
                massive = ds.GetMassFunction(startStep, stopStep);
                chartFunction_CVS.ChartAreas[0].AxisX.Title = "Ось X";
                chartFunction_CVS.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxOutput_CVS.Text = "";
                chartFunction_CVS.Series[0].Points.Clear();
                for (int i =0; i<=len-1; i++)
                {
                    chartFunction_CVS.Series[0].Points.AddXY(startStep, massive[i]);
                    textBoxOutput_CVS.AppendText(massive[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_CVS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V4.txt";
                File.WriteAllText(path, textBoxOutput_CVS.Text);
                DialogResult dialog = MessageBox.Show("Файл" + path + " сохранен успешно.\nОткрыть его в блокноте?","Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonInfo_CVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-23-1 Черепанов Вячеслав Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxOutput_CVS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
