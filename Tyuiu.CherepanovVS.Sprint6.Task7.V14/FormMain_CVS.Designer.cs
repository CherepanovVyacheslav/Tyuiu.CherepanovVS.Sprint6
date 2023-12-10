
namespace Tyuiu.CherepanovVS.Sprint6.Task7.V14
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_CVS));
            this.panelBatton_CVS = new System.Windows.Forms.Panel();
            this.buttonInfo_CVS = new System.Windows.Forms.Button();
            this.buttonSave_CVS = new System.Windows.Forms.Button();
            this.buttonOutputFile_CVS = new System.Windows.Forms.Button();
            this.buttonOpenFile_CVS = new System.Windows.Forms.Button();
            this.panelPropetry_CVS = new System.Windows.Forms.Panel();
            this.groupBoxProperty_CVS = new System.Windows.Forms.GroupBox();
            this.textBoxProperty_CVS = new System.Windows.Forms.TextBox();
            this.panelInputData_CVS = new System.Windows.Forms.Panel();
            this.groupBoxInputData_CVS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInputData_CVS = new System.Windows.Forms.DataGridView();
            this.panelOutputData_CVS = new System.Windows.Forms.Panel();
            this.groupBoxOutputData_CVS = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutputData_CVS = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_CVS = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_CVS = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialog_CVS = new System.Windows.Forms.SaveFileDialog();
            this.panelBatton_CVS.SuspendLayout();
            this.panelPropetry_CVS.SuspendLayout();
            this.groupBoxProperty_CVS.SuspendLayout();
            this.panelInputData_CVS.SuspendLayout();
            this.groupBoxInputData_CVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputData_CVS)).BeginInit();
            this.panelOutputData_CVS.SuspendLayout();
            this.groupBoxOutputData_CVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputData_CVS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBatton_CVS
            // 
            this.panelBatton_CVS.Controls.Add(this.buttonInfo_CVS);
            this.panelBatton_CVS.Controls.Add(this.buttonSave_CVS);
            this.panelBatton_CVS.Controls.Add(this.buttonOutputFile_CVS);
            this.panelBatton_CVS.Controls.Add(this.buttonOpenFile_CVS);
            this.panelBatton_CVS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBatton_CVS.Location = new System.Drawing.Point(0, 0);
            this.panelBatton_CVS.Name = "panelBatton_CVS";
            this.panelBatton_CVS.Size = new System.Drawing.Size(1178, 89);
            this.panelBatton_CVS.TabIndex = 0;
            // 
            // buttonInfo_CVS
            // 
            this.buttonInfo_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_CVS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo_CVS.BackgroundImage")));
            this.buttonInfo_CVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInfo_CVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_CVS.Location = new System.Drawing.Point(1095, 12);
            this.buttonInfo_CVS.Name = "buttonInfo_CVS";
            this.buttonInfo_CVS.Size = new System.Drawing.Size(71, 66);
            this.buttonInfo_CVS.TabIndex = 0;
            this.toolTip_CVS.SetToolTip(this.buttonInfo_CVS, "Сведения о программе");
            this.buttonInfo_CVS.UseVisualStyleBackColor = true;
            this.buttonInfo_CVS.Click += new System.EventHandler(this.buttonInfo_CVS_Click);
            this.buttonInfo_CVS.MouseEnter += new System.EventHandler(this.buttonInfo_CVS_MouseEnter);
            // 
            // buttonSave_CVS
            // 
            this.buttonSave_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave_CVS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave_CVS.BackgroundImage")));
            this.buttonSave_CVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSave_CVS.Enabled = false;
            this.buttonSave_CVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_CVS.Location = new System.Drawing.Point(190, 12);
            this.buttonSave_CVS.Name = "buttonSave_CVS";
            this.buttonSave_CVS.Size = new System.Drawing.Size(71, 66);
            this.buttonSave_CVS.TabIndex = 0;
            this.toolTip_CVS.SetToolTip(this.buttonSave_CVS, "Сохранить обработанные данные в файл вформате CSV");
            this.buttonSave_CVS.UseVisualStyleBackColor = true;
            this.buttonSave_CVS.Click += new System.EventHandler(this.buttonSave_CVS_Click);
            this.buttonSave_CVS.MouseEnter += new System.EventHandler(this.buttonSave_CVS_MouseEnter);
            // 
            // buttonOutputFile_CVS
            // 
            this.buttonOutputFile_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOutputFile_CVS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOutputFile_CVS.BackgroundImage")));
            this.buttonOutputFile_CVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOutputFile_CVS.Enabled = false;
            this.buttonOutputFile_CVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOutputFile_CVS.Location = new System.Drawing.Point(100, 12);
            this.buttonOutputFile_CVS.Name = "buttonOutputFile_CVS";
            this.buttonOutputFile_CVS.Size = new System.Drawing.Size(84, 66);
            this.buttonOutputFile_CVS.TabIndex = 0;
            this.toolTip_CVS.SetToolTip(this.buttonOutputFile_CVS, "Выполнить обработку данных");
            this.buttonOutputFile_CVS.UseVisualStyleBackColor = true;
            this.buttonOutputFile_CVS.Click += new System.EventHandler(this.buttonOutputFile_CVS_Click);
            this.buttonOutputFile_CVS.MouseEnter += new System.EventHandler(this.buttonOutputFile_CVS_MouseEnter);
            // 
            // buttonOpenFile_CVS
            // 
            this.buttonOpenFile_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenFile_CVS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_CVS.BackgroundImage")));
            this.buttonOpenFile_CVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonOpenFile_CVS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_CVS.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_CVS.Name = "buttonOpenFile_CVS";
            this.buttonOpenFile_CVS.Size = new System.Drawing.Size(82, 66);
            this.buttonOpenFile_CVS.TabIndex = 0;
            this.toolTip_CVS.SetToolTip(this.buttonOpenFile_CVS, "Открыть файл для обработки в CSV\r\n");
            this.buttonOpenFile_CVS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_CVS.Click += new System.EventHandler(this.buttonOpenFile_CVS_Click);
            // 
            // panelPropetry_CVS
            // 
            this.panelPropetry_CVS.Controls.Add(this.groupBoxProperty_CVS);
            this.panelPropetry_CVS.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPropetry_CVS.Location = new System.Drawing.Point(0, 89);
            this.panelPropetry_CVS.Name = "panelPropetry_CVS";
            this.panelPropetry_CVS.Size = new System.Drawing.Size(1178, 117);
            this.panelPropetry_CVS.TabIndex = 1;
            // 
            // groupBoxProperty_CVS
            // 
            this.groupBoxProperty_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProperty_CVS.Controls.Add(this.textBoxProperty_CVS);
            this.groupBoxProperty_CVS.Location = new System.Drawing.Point(13, 7);
            this.groupBoxProperty_CVS.Name = "groupBoxProperty_CVS";
            this.groupBoxProperty_CVS.Size = new System.Drawing.Size(1153, 107);
            this.groupBoxProperty_CVS.TabIndex = 0;
            this.groupBoxProperty_CVS.TabStop = false;
            this.groupBoxProperty_CVS.Text = "Условие:";
            // 
            // textBoxProperty_CVS
            // 
            this.textBoxProperty_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProperty_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProperty_CVS.Location = new System.Drawing.Point(6, 20);
            this.textBoxProperty_CVS.Multiline = true;
            this.textBoxProperty_CVS.Name = "textBoxProperty_CVS";
            this.textBoxProperty_CVS.ReadOnly = true;
            this.textBoxProperty_CVS.Size = new System.Drawing.Size(1141, 82);
            this.textBoxProperty_CVS.TabIndex = 0;
            this.textBoxProperty_CVS.Text = resources.GetString("textBoxProperty_CVS.Text");
            // 
            // panelInputData_CVS
            // 
            this.panelInputData_CVS.Controls.Add(this.groupBoxInputData_CVS);
            this.panelInputData_CVS.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInputData_CVS.Location = new System.Drawing.Point(0, 206);
            this.panelInputData_CVS.Name = "panelInputData_CVS";
            this.panelInputData_CVS.Size = new System.Drawing.Size(600, 744);
            this.panelInputData_CVS.TabIndex = 2;
            // 
            // groupBoxInputData_CVS
            // 
            this.groupBoxInputData_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInputData_CVS.Controls.Add(this.dataGridViewInputData_CVS);
            this.groupBoxInputData_CVS.Location = new System.Drawing.Point(12, 14);
            this.groupBoxInputData_CVS.Name = "groupBoxInputData_CVS";
            this.groupBoxInputData_CVS.Size = new System.Drawing.Size(585, 719);
            this.groupBoxInputData_CVS.TabIndex = 0;
            this.groupBoxInputData_CVS.TabStop = false;
            this.groupBoxInputData_CVS.Text = "Ввод:";
            // 
            // dataGridViewInputData_CVS
            // 
            this.dataGridViewInputData_CVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputData_CVS.ColumnHeadersVisible = false;
            this.dataGridViewInputData_CVS.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewInputData_CVS.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewInputData_CVS.Name = "dataGridViewInputData_CVS";
            this.dataGridViewInputData_CVS.RowHeadersVisible = false;
            this.dataGridViewInputData_CVS.RowHeadersWidth = 62;
            this.dataGridViewInputData_CVS.RowTemplate.Height = 28;
            this.dataGridViewInputData_CVS.Size = new System.Drawing.Size(576, 694);
            this.dataGridViewInputData_CVS.TabIndex = 0;
            // 
            // panelOutputData_CVS
            // 
            this.panelOutputData_CVS.Controls.Add(this.groupBoxOutputData_CVS);
            this.panelOutputData_CVS.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOutputData_CVS.Location = new System.Drawing.Point(606, 206);
            this.panelOutputData_CVS.Name = "panelOutputData_CVS";
            this.panelOutputData_CVS.Size = new System.Drawing.Size(572, 744);
            this.panelOutputData_CVS.TabIndex = 3;
            // 
            // groupBoxOutputData_CVS
            // 
            this.groupBoxOutputData_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutputData_CVS.Controls.Add(this.dataGridViewOutputData_CVS);
            this.groupBoxOutputData_CVS.Location = new System.Drawing.Point(7, 14);
            this.groupBoxOutputData_CVS.Name = "groupBoxOutputData_CVS";
            this.groupBoxOutputData_CVS.Size = new System.Drawing.Size(559, 718);
            this.groupBoxOutputData_CVS.TabIndex = 0;
            this.groupBoxOutputData_CVS.TabStop = false;
            this.groupBoxOutputData_CVS.Text = "Вывод:";
            // 
            // dataGridViewOutputData_CVS
            // 
            this.dataGridViewOutputData_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOutputData_CVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutputData_CVS.ColumnHeadersVisible = false;
            this.dataGridViewOutputData_CVS.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewOutputData_CVS.Name = "dataGridViewOutputData_CVS";
            this.dataGridViewOutputData_CVS.RowHeadersVisible = false;
            this.dataGridViewOutputData_CVS.RowHeadersWidth = 62;
            this.dataGridViewOutputData_CVS.RowTemplate.Height = 28;
            this.dataGridViewOutputData_CVS.Size = new System.Drawing.Size(547, 687);
            this.dataGridViewOutputData_CVS.TabIndex = 0;
            this.dataGridViewOutputData_CVS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOutputData_CVS_CellContentClick);
            // 
            // openFileDialogTask_CVS
            // 
            this.openFileDialogTask_CVS.FileName = "openFileDialog1";
            // 
            // toolTip_CVS
            // 
            this.toolTip_CVS.IsBalloon = true;
            this.toolTip_CVS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_CVS.ToolTipTitle = "Открыть файл";
            this.toolTip_CVS.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_CVS_Popup);
            // 
            // FormMain_CVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 950);
            this.Controls.Add(this.panelOutputData_CVS);
            this.Controls.Add(this.panelInputData_CVS);
            this.Controls.Add(this.panelPropetry_CVS);
            this.Controls.Add(this.panelBatton_CVS);
            this.MinimumSize = new System.Drawing.Size(1200, 1006);
            this.Name = "FormMain_CVS";
            this.Text = "Спринт 6 | Таск 7 | Вариант 14 | Черепанов В.С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelBatton_CVS.ResumeLayout(false);
            this.panelPropetry_CVS.ResumeLayout(false);
            this.groupBoxProperty_CVS.ResumeLayout(false);
            this.groupBoxProperty_CVS.PerformLayout();
            this.panelInputData_CVS.ResumeLayout(false);
            this.groupBoxInputData_CVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputData_CVS)).EndInit();
            this.panelOutputData_CVS.ResumeLayout(false);
            this.groupBoxOutputData_CVS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputData_CVS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBatton_CVS;
        private System.Windows.Forms.Button buttonInfo_CVS;
        private System.Windows.Forms.Button buttonSave_CVS;
        private System.Windows.Forms.Button buttonOutputFile_CVS;
        private System.Windows.Forms.Button buttonOpenFile_CVS;
        private System.Windows.Forms.Panel panelPropetry_CVS;
        private System.Windows.Forms.GroupBox groupBoxProperty_CVS;
        private System.Windows.Forms.TextBox textBoxProperty_CVS;
        private System.Windows.Forms.Panel panelInputData_CVS;
        private System.Windows.Forms.GroupBox groupBoxInputData_CVS;
        private System.Windows.Forms.DataGridView dataGridViewInputData_CVS;
        private System.Windows.Forms.Panel panelOutputData_CVS;
        private System.Windows.Forms.GroupBox groupBoxOutputData_CVS;
        private System.Windows.Forms.DataGridView dataGridViewOutputData_CVS;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_CVS;
        private System.Windows.Forms.ToolTip toolTip_CVS;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_CVS;
    }
}

