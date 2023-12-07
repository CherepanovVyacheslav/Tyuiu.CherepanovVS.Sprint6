
namespace Tyuiu.CherepanovVS.Sprint6.Task5.V7
{
    partial class FormMain_CVS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelProperty_CVS = new System.Windows.Forms.Panel();
            this.groupBoxProperty_CVS = new System.Windows.Forms.GroupBox();
            this.textBoxProperty_CVS = new System.Windows.Forms.TextBox();
            this.buttonResult_CVS = new System.Windows.Forms.Button();
            this.buttonOpenFile_CVS = new System.Windows.Forms.Button();
            this.buttonInfo_CVS = new System.Windows.Forms.Button();
            this.panelOutputData_CVS = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_CVS = new System.Windows.Forms.GroupBox();
            this.chartGraf_CVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewNums_CVS = new System.Windows.Forms.DataGridView();
            this.panelProperty_CVS.SuspendLayout();
            this.groupBoxProperty_CVS.SuspendLayout();
            this.panelOutputData_CVS.SuspendLayout();
            this.groupBoxOutPutData_CVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_CVS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_CVS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProperty_CVS
            // 
            this.panelProperty_CVS.Controls.Add(this.buttonInfo_CVS);
            this.panelProperty_CVS.Controls.Add(this.buttonOpenFile_CVS);
            this.panelProperty_CVS.Controls.Add(this.buttonResult_CVS);
            this.panelProperty_CVS.Controls.Add(this.groupBoxProperty_CVS);
            this.panelProperty_CVS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProperty_CVS.Location = new System.Drawing.Point(0, 0);
            this.panelProperty_CVS.Name = "panelProperty_CVS";
            this.panelProperty_CVS.Size = new System.Drawing.Size(1035, 118);
            this.panelProperty_CVS.TabIndex = 0;
            // 
            // groupBoxProperty_CVS
            // 
            this.groupBoxProperty_CVS.Controls.Add(this.textBoxProperty_CVS);
            this.groupBoxProperty_CVS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxProperty_CVS.Name = "groupBoxProperty_CVS";
            this.groupBoxProperty_CVS.Size = new System.Drawing.Size(534, 98);
            this.groupBoxProperty_CVS.TabIndex = 0;
            this.groupBoxProperty_CVS.TabStop = false;
            this.groupBoxProperty_CVS.Text = "Условие:";
            // 
            // textBoxProperty_CVS
            // 
            this.textBoxProperty_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProperty_CVS.Location = new System.Drawing.Point(7, 26);
            this.textBoxProperty_CVS.Multiline = true;
            this.textBoxProperty_CVS.Name = "textBoxProperty_CVS";
            this.textBoxProperty_CVS.ReadOnly = true;
            this.textBoxProperty_CVS.Size = new System.Drawing.Size(521, 70);
            this.textBoxProperty_CVS.TabIndex = 0;
            this.textBoxProperty_CVS.Text = "Прочитать данные из файла InPutFileTask5V7.txt. Вывести в dataGridView. Дан списо" +
    "к из 20 чисел. Вывести все числа, больше 5. Построить диаграмму по этим значения" +
    "м";
            // 
            // buttonResult_CVS
            // 
            this.buttonResult_CVS.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonResult_CVS.Location = new System.Drawing.Point(554, 13);
            this.buttonResult_CVS.Name = "buttonResult_CVS";
            this.buttonResult_CVS.Size = new System.Drawing.Size(121, 96);
            this.buttonResult_CVS.TabIndex = 1;
            this.buttonResult_CVS.Text = "Выполнить";
            this.buttonResult_CVS.UseVisualStyleBackColor = false;
            this.buttonResult_CVS.Click += new System.EventHandler(this.buttonResult_CVS_Click);
            // 
            // buttonOpenFile_CVS
            // 
            this.buttonOpenFile_CVS.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonOpenFile_CVS.Location = new System.Drawing.Point(681, 12);
            this.buttonOpenFile_CVS.Name = "buttonOpenFile_CVS";
            this.buttonOpenFile_CVS.Size = new System.Drawing.Size(121, 96);
            this.buttonOpenFile_CVS.TabIndex = 1;
            this.buttonOpenFile_CVS.Text = "Открыть файл";
            this.buttonOpenFile_CVS.UseVisualStyleBackColor = false;
            this.buttonOpenFile_CVS.Click += new System.EventHandler(this.buttonOpenFile_CVS_Click);
            // 
            // buttonInfo_CVS
            // 
            this.buttonInfo_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_CVS.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonInfo_CVS.Location = new System.Drawing.Point(902, 13);
            this.buttonInfo_CVS.Name = "buttonInfo_CVS";
            this.buttonInfo_CVS.Size = new System.Drawing.Size(121, 96);
            this.buttonInfo_CVS.TabIndex = 1;
            this.buttonInfo_CVS.Text = "Справка";
            this.buttonInfo_CVS.UseVisualStyleBackColor = false;
            this.buttonInfo_CVS.Click += new System.EventHandler(this.buttonInfo_CVS_Click);
            // 
            // panelOutputData_CVS
            // 
            this.panelOutputData_CVS.Controls.Add(this.groupBoxOutPutData_CVS);
            this.panelOutputData_CVS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutputData_CVS.Location = new System.Drawing.Point(0, 118);
            this.panelOutputData_CVS.Name = "panelOutputData_CVS";
            this.panelOutputData_CVS.Size = new System.Drawing.Size(200, 388);
            this.panelOutputData_CVS.TabIndex = 1;
            // 
            // groupBoxOutPutData_CVS
            // 
            this.groupBoxOutPutData_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxOutPutData_CVS.Controls.Add(this.dataGridViewNums_CVS);
            this.groupBoxOutPutData_CVS.Location = new System.Drawing.Point(13, 7);
            this.groupBoxOutPutData_CVS.Name = "groupBoxOutPutData_CVS";
            this.groupBoxOutPutData_CVS.Size = new System.Drawing.Size(184, 322);
            this.groupBoxOutPutData_CVS.TabIndex = 0;
            this.groupBoxOutPutData_CVS.TabStop = false;
            this.groupBoxOutPutData_CVS.Text = "Вывод данных:";
            // 
            // chartGraf_CVS
            // 
            this.chartGraf_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartGraf_CVS.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGraf_CVS.Legends.Add(legend2);
            this.chartGraf_CVS.Location = new System.Drawing.Point(229, 125);
            this.chartGraf_CVS.Name = "chartGraf_CVS";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGraf_CVS.Series.Add(series2);
            this.chartGraf_CVS.Size = new System.Drawing.Size(794, 369);
            this.chartGraf_CVS.TabIndex = 2;
            this.chartGraf_CVS.Text = "chart1";
            // 
            // dataGridViewNums_CVS
            // 
            this.dataGridViewNums_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNums_CVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_CVS.ColumnHeadersVisible = false;
            this.dataGridViewNums_CVS.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewNums_CVS.Name = "dataGridViewNums_CVS";
            this.dataGridViewNums_CVS.RowHeadersVisible = false;
            this.dataGridViewNums_CVS.RowHeadersWidth = 62;
            this.dataGridViewNums_CVS.RowTemplate.Height = 28;
            this.dataGridViewNums_CVS.Size = new System.Drawing.Size(178, 287);
            this.dataGridViewNums_CVS.TabIndex = 0;
            // 
            // FormMain_CVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 506);
            this.Controls.Add(this.chartGraf_CVS);
            this.Controls.Add(this.panelOutputData_CVS);
            this.Controls.Add(this.panelProperty_CVS);
            this.MinimumSize = new System.Drawing.Size(1035, 506);
            this.Name = "FormMain_CVS";
            this.Text = "Спринт 6 | Таск 5 | Вариант 7| Черепанов В.С.";
            this.Load += new System.EventHandler(this.FormMain_CVS_Load);
            this.panelProperty_CVS.ResumeLayout(false);
            this.groupBoxProperty_CVS.ResumeLayout(false);
            this.groupBoxProperty_CVS.PerformLayout();
            this.panelOutputData_CVS.ResumeLayout(false);
            this.groupBoxOutPutData_CVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_CVS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_CVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelProperty_CVS;
        private System.Windows.Forms.Button buttonInfo_CVS;
        private System.Windows.Forms.Button buttonOpenFile_CVS;
        private System.Windows.Forms.Button buttonResult_CVS;
        private System.Windows.Forms.GroupBox groupBoxProperty_CVS;
        private System.Windows.Forms.TextBox textBoxProperty_CVS;
        private System.Windows.Forms.Panel panelOutputData_CVS;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_CVS;
        private System.Windows.Forms.DataGridView dataGridViewNums_CVS;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartGraf_CVS;
    }
}

