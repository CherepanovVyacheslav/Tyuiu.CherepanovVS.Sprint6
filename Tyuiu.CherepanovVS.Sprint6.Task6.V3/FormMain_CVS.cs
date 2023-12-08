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
using Tyuiu.CherepanovVS.Sprint6.Task6.V3.Lib;

namespace Tyuiu.CherepanovVS.Sprint6.Task6.V3
{
    public partial class FormMain_CVS : Form
    {
        public FormMain_CVS()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private string openFilePath;

        private void FormMain_CVS_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void buttonOpenFile_CVS_Click(object sender, EventArgs e)
        {
            openFileDialogFindFile_CVS.ShowDialog();
            openFilePath= openFileDialogFindFile_CVS.FileName;
            textBoxInput_CVS.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_CVS.Text += "" + openFileDialogFindFile_CVS.FileName;
            buttonFindSymbol_CVS.Enabled = true;
        }

        private void buttonFindSymbol_CVS_Click(object sender, EventArgs e)
        {
            string str = "r";
            textBoxOutput_CVS.Text = ds.CollectTextFromFile(str, openFilePath);

        }

        private void buttonInfo_CVS_Click(object sender, EventArgs e)
        {
            FormAbout_CVS form = new FormAbout_CVS();
            form.ShowDialog();
        }
    }
}
