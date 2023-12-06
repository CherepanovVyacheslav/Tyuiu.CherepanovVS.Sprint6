
namespace Tyuiu.CherepanovVS.Sprint6.Task4.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxProperty_CVS = new System.Windows.Forms.GroupBox();
            this.textBoxProperty_CVS = new System.Windows.Forms.TextBox();
            this.groupBoxData_CVS = new System.Windows.Forms.GroupBox();
            this.textBoxInputData2_CVS = new System.Windows.Forms.TextBox();
            this.textBoxInputData_CVS = new System.Windows.Forms.TextBox();
            this.textBoxData2_CVS = new System.Windows.Forms.TextBox();
            this.textBoxData1_CVS = new System.Windows.Forms.TextBox();
            this.buttonResult_CVS = new System.Windows.Forms.Button();
            this.buttonSave_CVS = new System.Windows.Forms.Button();
            this.buttonInfo_CVS = new System.Windows.Forms.Button();
            this.groupBoxOutput_CVS = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_CVS = new System.Windows.Forms.TextBox();
            this.chartFunction_CVS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxProperty_CVS.SuspendLayout();
            this.groupBoxData_CVS.SuspendLayout();
            this.groupBoxOutput_CVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CVS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxProperty_CVS
            // 
            this.groupBoxProperty_CVS.Controls.Add(this.textBoxProperty_CVS);
            this.groupBoxProperty_CVS.Location = new System.Drawing.Point(13, 13);
            this.groupBoxProperty_CVS.Name = "groupBoxProperty_CVS";
            this.groupBoxProperty_CVS.Size = new System.Drawing.Size(565, 99);
            this.groupBoxProperty_CVS.TabIndex = 0;
            this.groupBoxProperty_CVS.TabStop = false;
            this.groupBoxProperty_CVS.Text = "Условие:";
            this.groupBoxProperty_CVS.Enter += new System.EventHandler(this.groupBoxProperty_CVS_Enter);
            // 
            // textBoxProperty_CVS
            // 
            this.textBoxProperty_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProperty_CVS.Location = new System.Drawing.Point(7, 26);
            this.textBoxProperty_CVS.Multiline = true;
            this.textBoxProperty_CVS.Name = "textBoxProperty_CVS";
            this.textBoxProperty_CVS.ReadOnly = true;
            this.textBoxProperty_CVS.Size = new System.Drawing.Size(553, 67);
            this.textBoxProperty_CVS.TabIndex = 0;
            this.textBoxProperty_CVS.Text = "Протабулировать функцию на заданном диапохоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox. построить график функции и сохранить в файл OutPutFileTask4V4.txt";
            // 
            // groupBoxData_CVS
            // 
            this.groupBoxData_CVS.Controls.Add(this.textBoxInputData2_CVS);
            this.groupBoxData_CVS.Controls.Add(this.textBoxInputData_CVS);
            this.groupBoxData_CVS.Controls.Add(this.textBoxData2_CVS);
            this.groupBoxData_CVS.Controls.Add(this.textBoxData1_CVS);
            this.groupBoxData_CVS.Location = new System.Drawing.Point(584, 13);
            this.groupBoxData_CVS.Name = "groupBoxData_CVS";
            this.groupBoxData_CVS.Size = new System.Drawing.Size(235, 100);
            this.groupBoxData_CVS.TabIndex = 1;
            this.groupBoxData_CVS.TabStop = false;
            this.groupBoxData_CVS.Text = "Ввод данных";
            // 
            // textBoxInputData2_CVS
            // 
            this.textBoxInputData2_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputData2_CVS.Location = new System.Drawing.Point(122, 50);
            this.textBoxInputData2_CVS.Name = "textBoxInputData2_CVS";
            this.textBoxInputData2_CVS.Size = new System.Drawing.Size(100, 19);
            this.textBoxInputData2_CVS.TabIndex = 1;
            // 
            // textBoxInputData_CVS
            // 
            this.textBoxInputData_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputData_CVS.Location = new System.Drawing.Point(7, 51);
            this.textBoxInputData_CVS.Name = "textBoxInputData_CVS";
            this.textBoxInputData_CVS.Size = new System.Drawing.Size(100, 19);
            this.textBoxInputData_CVS.TabIndex = 1;
            // 
            // textBoxData2_CVS
            // 
            this.textBoxData2_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData2_CVS.Location = new System.Drawing.Point(122, 25);
            this.textBoxData2_CVS.Name = "textBoxData2_CVS";
            this.textBoxData2_CVS.ReadOnly = true;
            this.textBoxData2_CVS.Size = new System.Drawing.Size(100, 19);
            this.textBoxData2_CVS.TabIndex = 0;
            this.textBoxData2_CVS.Text = "Конец шага:";
            // 
            // textBoxData1_CVS
            // 
            this.textBoxData1_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxData1_CVS.Location = new System.Drawing.Point(6, 25);
            this.textBoxData1_CVS.Name = "textBoxData1_CVS";
            this.textBoxData1_CVS.ReadOnly = true;
            this.textBoxData1_CVS.Size = new System.Drawing.Size(100, 19);
            this.textBoxData1_CVS.TabIndex = 0;
            this.textBoxData1_CVS.Text = "Старт шага:";
            // 
            // buttonResult_CVS
            // 
            this.buttonResult_CVS.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonResult_CVS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonResult_CVS.Location = new System.Drawing.Point(826, 13);
            this.buttonResult_CVS.Name = "buttonResult_CVS";
            this.buttonResult_CVS.Size = new System.Drawing.Size(107, 100);
            this.buttonResult_CVS.TabIndex = 2;
            this.buttonResult_CVS.Text = "Выполнить";
            this.buttonResult_CVS.UseVisualStyleBackColor = false;
            this.buttonResult_CVS.Click += new System.EventHandler(this.buttonResult_CVS_Click);
            // 
            // buttonSave_CVS
            // 
            this.buttonSave_CVS.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSave_CVS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSave_CVS.Location = new System.Drawing.Point(939, 13);
            this.buttonSave_CVS.Name = "buttonSave_CVS";
            this.buttonSave_CVS.Size = new System.Drawing.Size(122, 100);
            this.buttonSave_CVS.TabIndex = 2;
            this.buttonSave_CVS.Text = "Сохранить";
            this.buttonSave_CVS.UseVisualStyleBackColor = false;
            this.buttonSave_CVS.Click += new System.EventHandler(this.buttonSave_CVS_Click);
            // 
            // buttonInfo_CVS
            // 
            this.buttonInfo_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_CVS.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInfo_CVS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonInfo_CVS.Location = new System.Drawing.Point(1093, 12);
            this.buttonInfo_CVS.Name = "buttonInfo_CVS";
            this.buttonInfo_CVS.Size = new System.Drawing.Size(122, 100);
            this.buttonInfo_CVS.TabIndex = 2;
            this.buttonInfo_CVS.Text = "Справка";
            this.buttonInfo_CVS.UseVisualStyleBackColor = false;
            this.buttonInfo_CVS.Click += new System.EventHandler(this.buttonInfo_CVS_Click);
            // 
            // groupBoxOutput_CVS
            // 
            this.groupBoxOutput_CVS.Controls.Add(this.textBoxOutput_CVS);
            this.groupBoxOutput_CVS.Location = new System.Drawing.Point(13, 119);
            this.groupBoxOutput_CVS.Name = "groupBoxOutput_CVS";
            this.groupBoxOutput_CVS.Size = new System.Drawing.Size(200, 319);
            this.groupBoxOutput_CVS.TabIndex = 3;
            this.groupBoxOutput_CVS.TabStop = false;
            this.groupBoxOutput_CVS.Text = "Вывод:";
            // 
            // textBoxOutput_CVS
            // 
            this.textBoxOutput_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxOutput_CVS.Location = new System.Drawing.Point(7, 26);
            this.textBoxOutput_CVS.Multiline = true;
            this.textBoxOutput_CVS.Name = "textBoxOutput_CVS";
            this.textBoxOutput_CVS.ReadOnly = true;
            this.textBoxOutput_CVS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_CVS.Size = new System.Drawing.Size(187, 287);
            this.textBoxOutput_CVS.TabIndex = 0;
            this.textBoxOutput_CVS.TextChanged += new System.EventHandler(this.textBoxOutput_CVS_TextChanged);
            // 
            // chartFunction_CVS
            // 
            this.chartFunction_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartFunction_CVS.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFunction_CVS.Legends.Add(legend4);
            this.chartFunction_CVS.Location = new System.Drawing.Point(220, 119);
            this.chartFunction_CVS.Name = "chartFunction_CVS";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction_CVS.Series.Add(series4);
            this.chartFunction_CVS.Size = new System.Drawing.Size(995, 313);
            this.chartFunction_CVS.TabIndex = 4;
            this.chartFunction_CVS.Text = "График функции";
            title4.Name = "Title1";
            title4.Text = "График функции";
            this.chartFunction_CVS.Titles.Add(title4);
            // 
            // FormMain_CVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 459);
            this.Controls.Add(this.chartFunction_CVS);
            this.Controls.Add(this.groupBoxOutput_CVS);
            this.Controls.Add(this.buttonInfo_CVS);
            this.Controls.Add(this.buttonSave_CVS);
            this.Controls.Add(this.buttonResult_CVS);
            this.Controls.Add(this.groupBoxData_CVS);
            this.Controls.Add(this.groupBoxProperty_CVS);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MinimumSize = new System.Drawing.Size(1249, 515);
            this.Name = "FormMain_CVS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 4 | Черепнов В.С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxProperty_CVS.ResumeLayout(false);
            this.groupBoxProperty_CVS.PerformLayout();
            this.groupBoxData_CVS.ResumeLayout(false);
            this.groupBoxData_CVS.PerformLayout();
            this.groupBoxOutput_CVS.ResumeLayout(false);
            this.groupBoxOutput_CVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_CVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProperty_CVS;
        private System.Windows.Forms.TextBox textBoxProperty_CVS;
        private System.Windows.Forms.GroupBox groupBoxData_CVS;
        private System.Windows.Forms.TextBox textBoxInputData2_CVS;
        private System.Windows.Forms.TextBox textBoxInputData_CVS;
        private System.Windows.Forms.TextBox textBoxData2_CVS;
        private System.Windows.Forms.TextBox textBoxData1_CVS;
        private System.Windows.Forms.Button buttonResult_CVS;
        private System.Windows.Forms.Button buttonSave_CVS;
        private System.Windows.Forms.Button buttonInfo_CVS;
        private System.Windows.Forms.GroupBox groupBoxOutput_CVS;
        private System.Windows.Forms.TextBox textBoxOutput_CVS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_CVS;
    }
}

