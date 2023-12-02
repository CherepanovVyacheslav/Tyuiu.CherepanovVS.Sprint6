
namespace Tyuiu.CherepanovVS.Sprint6.Task3.V13
{
    partial class FormMain_VSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_VSC));
            this.groupBoxCondition_VSC = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_VSC = new System.Windows.Forms.TextBox();
            this.groupBoxResult_VSC = new System.Windows.Forms.GroupBox();
            this.textBoxResult_VSC = new System.Windows.Forms.TextBox();
            this.textBoxOutputData_VSC = new System.Windows.Forms.TextBox();
            this.buttonResult_VSC = new System.Windows.Forms.Button();
            this.buttonInform_VSC = new System.Windows.Forms.Button();
            this.dataGridViewMatrix_VSC = new System.Windows.Forms.DataGridView();
            this.groupBoxCondition_VSC.SuspendLayout();
            this.groupBoxResult_VSC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_VSC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition_VSC
            // 
            this.groupBoxCondition_VSC.Controls.Add(this.textBoxCondition_VSC);
            this.groupBoxCondition_VSC.Location = new System.Drawing.Point(13, 13);
            this.groupBoxCondition_VSC.Name = "groupBoxCondition_VSC";
            this.groupBoxCondition_VSC.Size = new System.Drawing.Size(351, 425);
            this.groupBoxCondition_VSC.TabIndex = 0;
            this.groupBoxCondition_VSC.TabStop = false;
            this.groupBoxCondition_VSC.Text = "Условие";
            // 
            // textBoxCondition_VSC
            // 
            this.textBoxCondition_VSC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_VSC.Location = new System.Drawing.Point(6, 25);
            this.textBoxCondition_VSC.Multiline = true;
            this.textBoxCondition_VSC.Name = "textBoxCondition_VSC";
            this.textBoxCondition_VSC.ReadOnly = true;
            this.textBoxCondition_VSC.Size = new System.Drawing.Size(339, 291);
            this.textBoxCondition_VSC.TabIndex = 0;
            this.textBoxCondition_VSC.Text = resources.GetString("textBoxCondition_VSC.Text");
            // 
            // groupBoxResult_VSC
            // 
            this.groupBoxResult_VSC.Controls.Add(this.textBoxOutputData_VSC);
            this.groupBoxResult_VSC.Controls.Add(this.textBoxResult_VSC);
            this.groupBoxResult_VSC.Location = new System.Drawing.Point(636, 13);
            this.groupBoxResult_VSC.Name = "groupBoxResult_VSC";
            this.groupBoxResult_VSC.Size = new System.Drawing.Size(152, 91);
            this.groupBoxResult_VSC.TabIndex = 1;
            this.groupBoxResult_VSC.TabStop = false;
            this.groupBoxResult_VSC.Text = "Вывод данных";
            // 
            // textBoxResult_VSC
            // 
            this.textBoxResult_VSC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_VSC.Location = new System.Drawing.Point(6, 25);
            this.textBoxResult_VSC.Name = "textBoxResult_VSC";
            this.textBoxResult_VSC.ReadOnly = true;
            this.textBoxResult_VSC.Size = new System.Drawing.Size(100, 19);
            this.textBoxResult_VSC.TabIndex = 0;
            this.textBoxResult_VSC.Text = "Результат:";
            // 
            // textBoxOutputData_VSC
            // 
            this.textBoxOutputData_VSC.Location = new System.Drawing.Point(6, 50);
            this.textBoxOutputData_VSC.Multiline = true;
            this.textBoxOutputData_VSC.Name = "textBoxOutputData_VSC";
            this.textBoxOutputData_VSC.ReadOnly = true;
            this.textBoxOutputData_VSC.Size = new System.Drawing.Size(134, 26);
            this.textBoxOutputData_VSC.TabIndex = 1;
            this.textBoxOutputData_VSC.TextChanged += new System.EventHandler(this.textBoxOutputData_VSC_TextChanged);
            // 
            // buttonResult_VSC
            // 
            this.buttonResult_VSC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonResult_VSC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonResult_VSC.Location = new System.Drawing.Point(678, 406);
            this.buttonResult_VSC.Name = "buttonResult_VSC";
            this.buttonResult_VSC.Size = new System.Drawing.Size(110, 32);
            this.buttonResult_VSC.TabIndex = 3;
            this.buttonResult_VSC.Text = "Выполнить";
            this.buttonResult_VSC.UseVisualStyleBackColor = false;
            this.buttonResult_VSC.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonInform_VSC
            // 
            this.buttonInform_VSC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonInform_VSC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonInform_VSC.Location = new System.Drawing.Point(636, 406);
            this.buttonInform_VSC.Name = "buttonInform_VSC";
            this.buttonInform_VSC.Size = new System.Drawing.Size(36, 32);
            this.buttonInform_VSC.TabIndex = 3;
            this.buttonInform_VSC.Text = "?";
            this.buttonInform_VSC.UseVisualStyleBackColor = false;
            this.buttonInform_VSC.Click += new System.EventHandler(this.buttonInform_Click);
            // 
            // dataGridViewMatrix_VSC
            // 
            this.dataGridViewMatrix_VSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_VSC.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_VSC.Location = new System.Drawing.Point(371, 22);
            this.dataGridViewMatrix_VSC.Name = "dataGridViewMatrix_VSC";
            this.dataGridViewMatrix_VSC.RowHeadersVisible = false;
            this.dataGridViewMatrix_VSC.RowHeadersWidth = 62;
            this.dataGridViewMatrix_VSC.RowTemplate.Height = 28;
            this.dataGridViewMatrix_VSC.Size = new System.Drawing.Size(259, 416);
            this.dataGridViewMatrix_VSC.TabIndex = 4;
            // 
            // FormMain_VSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMatrix_VSC);
            this.Controls.Add(this.buttonInform_VSC);
            this.Controls.Add(this.buttonResult_VSC);
            this.Controls.Add(this.groupBoxResult_VSC);
            this.Controls.Add(this.groupBoxCondition_VSC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain_VSC";
            this.Text = "Спринт 6 | Таск3 | Вариант 13| Черепанов В.С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_VSC.ResumeLayout(false);
            this.groupBoxCondition_VSC.PerformLayout();
            this.groupBoxResult_VSC.ResumeLayout(false);
            this.groupBoxResult_VSC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_VSC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_VSC;
        private System.Windows.Forms.TextBox textBoxCondition_VSC;
        private System.Windows.Forms.GroupBox groupBoxResult_VSC;
        private System.Windows.Forms.TextBox textBoxOutputData_VSC;
        private System.Windows.Forms.TextBox textBoxResult_VSC;
        private System.Windows.Forms.Button buttonResult_VSC;
        private System.Windows.Forms.Button buttonInform_VSC;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_VSC;
    }
}

