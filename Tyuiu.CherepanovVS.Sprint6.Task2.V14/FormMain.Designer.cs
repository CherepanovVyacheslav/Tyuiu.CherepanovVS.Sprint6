
namespace Tyuiu.CherepanovVS.Sprint6.Task2.V14
{
    partial class FormMain
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
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.groupBoxStep = new System.Windows.Forms.GroupBox();
            this.textBoxstopStep = new System.Windows.Forms.TextBox();
            this.textBoxstartStep = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxInputData1 = new System.Windows.Forms.TextBox();
            this.buttonReference = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxStep.SuspendLayout();
            this.groupBoxOutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBoxCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(537, 329);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition.Location = new System.Drawing.Point(7, 26);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(524, 94);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести на DataGrindVie" +
    "w и постороить график функции.";
            // 
            // groupBoxStep
            // 
            this.groupBoxStep.Controls.Add(this.textBoxstopStep);
            this.groupBoxStep.Controls.Add(this.textBoxstartStep);
            this.groupBoxStep.Controls.Add(this.textBox1);
            this.groupBoxStep.Controls.Add(this.textBoxInputData1);
            this.groupBoxStep.Location = new System.Drawing.Point(13, 348);
            this.groupBoxStep.Name = "groupBoxStep";
            this.groupBoxStep.Size = new System.Drawing.Size(256, 90);
            this.groupBoxStep.TabIndex = 1;
            this.groupBoxStep.TabStop = false;
            this.groupBoxStep.Text = "Ввод данных";
            // 
            // textBoxstopStep
            // 
            this.textBoxstopStep.Location = new System.Drawing.Point(138, 51);
            this.textBoxstopStep.Name = "textBoxstopStep";
            this.textBoxstopStep.Size = new System.Drawing.Size(100, 26);
            this.textBoxstopStep.TabIndex = 1;
            // 
            // textBoxstartStep
            // 
            this.textBoxstartStep.Location = new System.Drawing.Point(7, 52);
            this.textBoxstartStep.Name = "textBoxstartStep";
            this.textBoxstartStep.Size = new System.Drawing.Size(100, 26);
            this.textBoxstartStep.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(138, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 19);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Старт шага:";
            // 
            // textBoxInputData1
            // 
            this.textBoxInputData1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputData1.Location = new System.Drawing.Point(7, 26);
            this.textBoxInputData1.Name = "textBoxInputData1";
            this.textBoxInputData1.ReadOnly = true;
            this.textBoxInputData1.Size = new System.Drawing.Size(100, 19);
            this.textBoxInputData1.TabIndex = 0;
            this.textBoxInputData1.Text = "Старт шага:";
            // 
            // buttonReference
            // 
            this.buttonReference.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonReference.Location = new System.Drawing.Point(276, 349);
            this.buttonReference.Name = "buttonReference";
            this.buttonReference.Size = new System.Drawing.Size(100, 89);
            this.buttonReference.TabIndex = 2;
            this.buttonReference.Text = "Справка";
            this.buttonReference.UseVisualStyleBackColor = false;
            this.buttonReference.Click += new System.EventHandler(this.buttonReference_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonResult.Location = new System.Drawing.Point(382, 349);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(168, 89);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = "Выполнить";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            this.buttonResult.Leave += new System.EventHandler(this.buttonResult_Leave);
            this.buttonResult.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonResult_MouseDown);
            this.buttonResult.MouseEnter += new System.EventHandler(this.buttonResult_MouseEnter);
            this.buttonResult.MouseLeave += new System.EventHandler(this.buttonResult_MouseLeave);
            // 
            // groupBoxOutputData
            // 
            this.groupBoxOutputData.Controls.Add(this.chartFunction);
            this.groupBoxOutputData.Controls.Add(this.dataGridViewFunction);
            this.groupBoxOutputData.Controls.Add(this.textBoxOutput);
            this.groupBoxOutputData.Location = new System.Drawing.Point(557, 13);
            this.groupBoxOutputData.Name = "groupBoxOutputData";
            this.groupBoxOutputData.Size = new System.Drawing.Size(453, 425);
            this.groupBoxOutputData.TabIndex = 3;
            this.groupBoxOutputData.TabStop = false;
            this.groupBoxOutputData.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction.Legends.Add(legend2);
            this.chartFunction.Location = new System.Drawing.Point(126, 58);
            this.chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction.Series.Add(series2);
            this.chartFunction.Size = new System.Drawing.Size(321, 354);
            this.chartFunction.TabIndex = 2;
            this.chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Column1});
            this.dataGridViewFunction.Location = new System.Drawing.Point(6, 59);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.RowHeadersWidth = 62;
            this.dataGridViewFunction.RowTemplate.Height = 28;
            this.dataGridViewFunction.Size = new System.Drawing.Size(114, 354);
            this.dataGridViewFunction.TabIndex = 1;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 8;
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "F(x)";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput.Location = new System.Drawing.Point(6, 26);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(100, 26);
            this.textBoxOutput.TabIndex = 0;
            this.textBoxOutput.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1037, 450);
            this.Controls.Add(this.groupBoxOutputData);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonReference);
            this.Controls.Add(this.groupBoxStep);
            this.Controls.Add(this.groupBoxCondition);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 14 | Черепанов В.С.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxStep.ResumeLayout(false);
            this.groupBoxStep.PerformLayout();
            this.groupBoxOutputData.ResumeLayout(false);
            this.groupBoxOutputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxStep;
        private System.Windows.Forms.TextBox textBoxstopStep;
        private System.Windows.Forms.TextBox textBoxstartStep;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxInputData1;
        private System.Windows.Forms.Button buttonReference;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

