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
using Tyuiu.CherepanovVS.Sprint6.Task7.V14.Lib;

namespace Tyuiu.CherepanovVS.Sprint6.Task7.V14
{
    public partial class FormMain_CVS : Form
    {
        public FormMain_CVS()
        {
            InitializeComponent();

            openFileDialogTask_CVS.Filter = "Значения разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_CVS.Filter = "Значения разделённые запятыми(*.csv) | *.csv | Все файлы(*.*) | *.* ";
        }
        static int rows;
        static int colums;
        static string path;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string path)
        {
            string data = File.ReadAllText(path);
            
            
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] massive = new int[rows, colums];


            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    massive[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return massive;


        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void toolTip_CVS_Popup(object sender, PopupEventArgs e)
        {

        }

        private void buttonOpenFile_CVS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_CVS.ShowDialog();
            path = openFileDialogTask_CVS.FileName;
            int[,] massive = new int[rows, colums];
            massive = LoadFromFileData(path);
            dataGridViewInputData_CVS.ColumnCount = colums;
            dataGridViewInputData_CVS.RowCount = rows;
            dataGridViewOutputData_CVS.ColumnCount = colums;
            dataGridViewOutputData_CVS.RowCount = rows;
            for (int c = 0; c < colums; c++)
            {
                dataGridViewOutputData_CVS.Columns[c].Width = 25;
                dataGridViewInputData_CVS.Columns[c].Width = 25;

            }

            for (int r = 0; r < rows; r++)
            {
                for (int co = 0; co < colums; co++)
                {
                    dataGridViewInputData_CVS.Rows[r].Cells[co].Value = massive[r, co];

                }
            }
            massive = ds.GetMatrix(LoadFromFileData(path));
            buttonOutputFile_CVS.Enabled = true;
        }

        private void buttonOutputFile_CVS_Click(object sender, EventArgs e)
        {
            int[,] massive = new int[rows, colums];
            massive = ds.GetMatrix(LoadFromFileData(path));
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutputData_CVS.Rows[r].Cells[c].Value = massive[r, c];

                }
            }
            buttonSave_CVS.Enabled = true;


        }

        private void buttonSave_CVS_Click(object sender, EventArgs e)
        {
            saveFileDialog_CVS.FileName = "OutputFileTask7";
            saveFileDialog_CVS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_CVS.ShowDialog();
            string path = saveFileDialog_CVS.FileName;
            FileInfo file = new FileInfo(path);
            bool Exist = file.Exists;
            if (Exist)
            {
                File.Delete(path);
            }


            int rows = dataGridViewOutputData_CVS.RowCount;
            int colums = dataGridViewOutputData_CVS.ColumnCount;
            string line = "";
            for (int i = 0; i < rows; i++)
            {
                for ( int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        line += dataGridViewOutputData_CVS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        line += dataGridViewOutputData_CVS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, line + Environment.NewLine);
                line = "";
                
            }

        }

        private void buttonInfo_CVS_Click(object sender, EventArgs e)
        {
            FormAbout_CVS form = new FormAbout_CVS();
            form.ShowDialog();
        }

        private void buttonOutputFile_CVS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_CVS.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_CVS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_CVS.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInfo_CVS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_CVS.ToolTipTitle = "Справка";
        }

        private void dataGridViewOutputData_CVS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
