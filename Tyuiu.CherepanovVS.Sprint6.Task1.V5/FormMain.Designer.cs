
namespace Tyuiu.CherepanovVS.Sprint6.Task1.V5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.grouBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.pictureBoxCondition = new System.Windows.Forms.PictureBox();
            this.groupBoxCalc = new System.Windows.Forms.GroupBox();
            this.textBoxCalck = new System.Windows.Forms.TextBox();
            this.textBoxCalck2 = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.textBoxData2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.groupBoxConclusion = new System.Windows.Forms.GroupBox();
            this.textBoxConclusionResult = new System.Windows.Forms.TextBox();
            this.textBoxresulttable = new System.Windows.Forms.TextBox();
            this.grouBoxCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).BeginInit();
            this.groupBoxCalc.SuspendLayout();
            this.groupBoxConclusion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grouBoxCondition
            // 
            this.grouBoxCondition.Controls.Add(this.pictureBoxCondition);
            this.grouBoxCondition.Controls.Add(this.textBoxCondition);
            this.grouBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.grouBoxCondition.Name = "grouBoxCondition";
            this.grouBoxCondition.Size = new System.Drawing.Size(509, 332);
            this.grouBoxCondition.TabIndex = 0;
            this.grouBoxCondition.TabStop = false;
            this.grouBoxCondition.Text = "Условие";
            // 
            // textBoxCondition
            // 
            this.textBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition.Location = new System.Drawing.Point(6, 38);
            this.textBoxCondition.Multiline = true;
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.ReadOnly = true;
            this.textBoxCondition.Size = new System.Drawing.Size(477, 62);
            this.textBoxCondition.TabIndex = 0;
            this.textBoxCondition.Text = "Протабулировать выражеине на заданном диапозоне. Результат вывести в виде таблицы" +
    ".";
            // 
            // pictureBoxCondition
            // 
            this.pictureBoxCondition.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCondition.Image")));
            this.pictureBoxCondition.Location = new System.Drawing.Point(6, 95);
            this.pictureBoxCondition.Name = "pictureBoxCondition";
            this.pictureBoxCondition.Size = new System.Drawing.Size(345, 89);
            this.pictureBoxCondition.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCondition.TabIndex = 1;
            this.pictureBoxCondition.TabStop = false;
            // 
            // groupBoxCalc
            // 
            this.groupBoxCalc.Controls.Add(this.textBoxData2);
            this.groupBoxCalc.Controls.Add(this.textBoxData);
            this.groupBoxCalc.Controls.Add(this.textBoxCalck2);
            this.groupBoxCalc.Controls.Add(this.textBoxCalck);
            this.groupBoxCalc.Location = new System.Drawing.Point(18, 350);
            this.groupBoxCalc.Name = "groupBoxCalc";
            this.groupBoxCalc.Size = new System.Drawing.Size(254, 88);
            this.groupBoxCalc.TabIndex = 1;
            this.groupBoxCalc.TabStop = false;
            this.groupBoxCalc.Text = "Ввод данных";
            // 
            // textBoxCalck
            // 
            this.textBoxCalck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCalck.Location = new System.Drawing.Point(6, 25);
            this.textBoxCalck.Name = "textBoxCalck";
            this.textBoxCalck.ReadOnly = true;
            this.textBoxCalck.Size = new System.Drawing.Size(108, 19);
            this.textBoxCalck.TabIndex = 0;
            this.textBoxCalck.Text = "Старт шага:";
            // 
            // textBoxCalck2
            // 
            this.textBoxCalck2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCalck2.Location = new System.Drawing.Point(121, 25);
            this.textBoxCalck2.Name = "textBoxCalck2";
            this.textBoxCalck2.ReadOnly = true;
            this.textBoxCalck2.Size = new System.Drawing.Size(111, 19);
            this.textBoxCalck2.TabIndex = 0;
            this.textBoxCalck2.Text = "Конец шага:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(6, 50);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(101, 26);
            this.textBoxData.TabIndex = 1;
            // 
            // textBoxData2
            // 
            this.textBoxData2.Location = new System.Drawing.Point(121, 50);
            this.textBoxData2.Name = "textBoxData2";
            this.textBoxData2.Size = new System.Drawing.Size(96, 26);
            this.textBoxData2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(290, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 80);
            this.button1.TabIndex = 2;
            this.button1.Text = "Справка";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.Lime;
            this.buttonResult.Location = new System.Drawing.Point(381, 358);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(140, 80);
            this.buttonResult.TabIndex = 2;
            this.buttonResult.Text = "Выполнить";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // groupBoxConclusion
            // 
            this.groupBoxConclusion.Controls.Add(this.textBoxresulttable);
            this.groupBoxConclusion.Controls.Add(this.textBoxConclusionResult);
            this.groupBoxConclusion.Location = new System.Drawing.Point(527, 12);
            this.groupBoxConclusion.Name = "groupBoxConclusion";
            this.groupBoxConclusion.Size = new System.Drawing.Size(320, 426);
            this.groupBoxConclusion.TabIndex = 3;
            this.groupBoxConclusion.TabStop = false;
            this.groupBoxConclusion.Text = "Вывод данных:";
            // 
            // textBoxConclusionResult
            // 
            this.textBoxConclusionResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxConclusionResult.Location = new System.Drawing.Point(6, 25);
            this.textBoxConclusionResult.Name = "textBoxConclusionResult";
            this.textBoxConclusionResult.ReadOnly = true;
            this.textBoxConclusionResult.Size = new System.Drawing.Size(100, 19);
            this.textBoxConclusionResult.TabIndex = 0;
            this.textBoxConclusionResult.Text = "Результат:";
            this.textBoxConclusionResult.TextChanged += new System.EventHandler(this.textBoxConclusionResult_TextChanged);
            // 
            // textBoxresulttable
            // 
            this.textBoxresulttable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxresulttable.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxresulttable.Location = new System.Drawing.Point(6, 50);
            this.textBoxresulttable.Multiline = true;
            this.textBoxresulttable.Name = "textBoxresulttable";
            this.textBoxresulttable.ReadOnly = true;
            this.textBoxresulttable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxresulttable.Size = new System.Drawing.Size(314, 364);
            this.textBoxresulttable.TabIndex = 1;
            this.textBoxresulttable.TextChanged += new System.EventHandler(this.textBoxresulttable_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.groupBoxConclusion);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBoxCalc);
            this.Controls.Add(this.grouBoxCondition);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1| Вариант 5 | Черепанов В.С.";
            this.grouBoxCondition.ResumeLayout(false);
            this.grouBoxCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition)).EndInit();
            this.groupBoxCalc.ResumeLayout(false);
            this.groupBoxCalc.PerformLayout();
            this.groupBoxConclusion.ResumeLayout(false);
            this.groupBoxConclusion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grouBoxCondition;
        private System.Windows.Forms.PictureBox pictureBoxCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.GroupBox groupBoxCalc;
        private System.Windows.Forms.TextBox textBoxData2;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.TextBox textBoxCalck2;
        private System.Windows.Forms.TextBox textBoxCalck;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.GroupBox groupBoxConclusion;
        private System.Windows.Forms.TextBox textBoxConclusionResult;
        private System.Windows.Forms.TextBox textBoxresulttable;
    }
}

