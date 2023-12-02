using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.CherepanovVS.Sprint6.Task3.V13.Lib;


namespace Tyuiu.CherepanovVS.Sprint6.Task3.V13
{
    public partial class FormMain_VSC : Form
    {
        public FormMain_VSC()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int [,] matrix  = { { -7, 34, -2, 25, 5 }, { -16, -12, 30, -3, 17 }, { 3, -15, 12, 5, -5 }, { 17, 22, -3, 32, -11 }, { 9, 28, 1, -9, -2 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;
            dataGridViewMatrix_VSC.ColumnCount = columns;
            dataGridViewMatrix_VSC.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_VSC.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_VSC.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);

                }
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            matrix = ds.Calculate(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewMatrix_VSC.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void buttonInform_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-23-1 Черепанов Вячеслав Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxOutputData_VSC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
