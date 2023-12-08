
namespace Tyuiu.CherepanovVS.Sprint6.Task6.V3
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
            this.panelButtons_CVS = new System.Windows.Forms.Panel();
            this.buttonOpenFile_CVS = new System.Windows.Forms.Button();
            this.openFileDialogFindFile_CVS = new System.Windows.Forms.OpenFileDialog();
            this.toolTipOpenFile_CVS = new System.Windows.Forms.ToolTip(this.components);
            this.buttonFindSymbol_CVS = new System.Windows.Forms.Button();
            this.toolTipFindSymbol_CVS = new System.Windows.Forms.ToolTip(this.components);
            this.buttonInfo_CVS = new System.Windows.Forms.Button();
            this.groupBoxProperty_CVS = new System.Windows.Forms.GroupBox();
            this.textBoxProperty_CVS = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_CVS = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPut_CVS = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_CVS = new System.Windows.Forms.TextBox();
            this.textBoxInput_CVS = new System.Windows.Forms.TextBox();
            this.openFileDialog_CVS = new System.Windows.Forms.OpenFileDialog();
            this.panelButtons_CVS.SuspendLayout();
            this.groupBoxProperty_CVS.SuspendLayout();
            this.groupBoxInPut_CVS.SuspendLayout();
            this.groupBoxOutPut_CVS.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_CVS
            // 
            this.panelButtons_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons_CVS.Controls.Add(this.buttonInfo_CVS);
            this.panelButtons_CVS.Controls.Add(this.buttonFindSymbol_CVS);
            this.panelButtons_CVS.Controls.Add(this.buttonOpenFile_CVS);
            this.panelButtons_CVS.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_CVS.Name = "panelButtons_CVS";
            this.panelButtons_CVS.Size = new System.Drawing.Size(1016, 119);
            this.panelButtons_CVS.TabIndex = 0;
            // 
            // buttonOpenFile_CVS
            // 
            this.buttonOpenFile_CVS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_CVS.BackgroundImage")));
            this.buttonOpenFile_CVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOpenFile_CVS.Location = new System.Drawing.Point(3, 12);
            this.buttonOpenFile_CVS.Name = "buttonOpenFile_CVS";
            this.buttonOpenFile_CVS.Size = new System.Drawing.Size(116, 93);
            this.buttonOpenFile_CVS.TabIndex = 0;
            this.buttonOpenFile_CVS.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTipOpenFile_CVS.SetToolTip(this.buttonOpenFile_CVS, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_CVS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_CVS.Click += new System.EventHandler(this.buttonOpenFile_CVS_Click);
            // 
            // openFileDialogFindFile_CVS
            // 
            this.openFileDialogFindFile_CVS.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // toolTipOpenFile_CVS
            // 
            this.toolTipOpenFile_CVS.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipOpenFile_CVS.ToolTipTitle = "Подсказка";
            // 
            // buttonFindSymbol_CVS
            // 
            this.buttonFindSymbol_CVS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFindSymbol_CVS.BackgroundImage")));
            this.buttonFindSymbol_CVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFindSymbol_CVS.Enabled = false;
            this.buttonFindSymbol_CVS.Location = new System.Drawing.Point(125, 12);
            this.buttonFindSymbol_CVS.Name = "buttonFindSymbol_CVS";
            this.buttonFindSymbol_CVS.Size = new System.Drawing.Size(116, 93);
            this.buttonFindSymbol_CVS.TabIndex = 0;
            this.buttonFindSymbol_CVS.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.toolTipOpenFile_CVS.SetToolTip(this.buttonFindSymbol_CVS, "Производит поис в файле вхождение символов \"r\"\r\nи конкатенирует строки в которых " +
        "находятся эти символы");
            this.buttonFindSymbol_CVS.UseVisualStyleBackColor = true;
            this.buttonFindSymbol_CVS.Click += new System.EventHandler(this.buttonFindSymbol_CVS_Click);
            // 
            // buttonInfo_CVS
            // 
            this.buttonInfo_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_CVS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInfo_CVS.BackgroundImage")));
            this.buttonInfo_CVS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInfo_CVS.Location = new System.Drawing.Point(888, 12);
            this.buttonInfo_CVS.Name = "buttonInfo_CVS";
            this.buttonInfo_CVS.Size = new System.Drawing.Size(116, 93);
            this.buttonInfo_CVS.TabIndex = 0;
            this.buttonInfo_CVS.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonInfo_CVS.UseVisualStyleBackColor = true;
            this.buttonInfo_CVS.Click += new System.EventHandler(this.buttonInfo_CVS_Click);
            // 
            // groupBoxProperty_CVS
            // 
            this.groupBoxProperty_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProperty_CVS.Controls.Add(this.textBoxProperty_CVS);
            this.groupBoxProperty_CVS.Location = new System.Drawing.Point(3, 125);
            this.groupBoxProperty_CVS.Name = "groupBoxProperty_CVS";
            this.groupBoxProperty_CVS.Size = new System.Drawing.Size(1013, 100);
            this.groupBoxProperty_CVS.TabIndex = 1;
            this.groupBoxProperty_CVS.TabStop = false;
            this.groupBoxProperty_CVS.Text = "Условие:";
            // 
            // textBoxProperty_CVS
            // 
            this.textBoxProperty_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProperty_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxProperty_CVS.Location = new System.Drawing.Point(10, 26);
            this.textBoxProperty_CVS.Multiline = true;
            this.textBoxProperty_CVS.Name = "textBoxProperty_CVS";
            this.textBoxProperty_CVS.ReadOnly = true;
            this.textBoxProperty_CVS.Size = new System.Drawing.Size(991, 59);
            this.textBoxProperty_CVS.TabIndex = 0;
            this.textBoxProperty_CVS.Text = "Дан файл InPutFileTask6V3.txt который может находится в любом месте на диске. Заг" +
    "рузить файл в textBoxIn через openFileDialog. Вывести слова в которых встречаетс" +
    "я r в результирующую строку.";
            // 
            // groupBoxInPut_CVS
            // 
            this.groupBoxInPut_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInPut_CVS.Controls.Add(this.textBoxInput_CVS);
            this.groupBoxInPut_CVS.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInPut_CVS.Location = new System.Drawing.Point(3, 231);
            this.groupBoxInPut_CVS.Name = "groupBoxInPut_CVS";
            this.groupBoxInPut_CVS.Size = new System.Drawing.Size(495, 276);
            this.groupBoxInPut_CVS.TabIndex = 2;
            this.groupBoxInPut_CVS.TabStop = false;
            this.groupBoxInPut_CVS.Text = "Ввод:";
            // 
            // groupBoxOutPut_CVS
            // 
            this.groupBoxOutPut_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutPut_CVS.Controls.Add(this.textBoxOutput_CVS);
            this.groupBoxOutPut_CVS.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut_CVS.Location = new System.Drawing.Point(504, 231);
            this.groupBoxOutPut_CVS.Name = "groupBoxOutPut_CVS";
            this.groupBoxOutPut_CVS.Size = new System.Drawing.Size(500, 276);
            this.groupBoxOutPut_CVS.TabIndex = 2;
            this.groupBoxOutPut_CVS.TabStop = false;
            this.groupBoxOutPut_CVS.Text = "Вывод:";
            // 
            // textBoxOutput_CVS
            // 
            this.textBoxOutput_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput_CVS.Location = new System.Drawing.Point(6, 99);
            this.textBoxOutput_CVS.Multiline = true;
            this.textBoxOutput_CVS.Name = "textBoxOutput_CVS";
            this.textBoxOutput_CVS.ReadOnly = true;
            this.textBoxOutput_CVS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_CVS.Size = new System.Drawing.Size(488, 170);
            this.textBoxOutput_CVS.TabIndex = 0;
            // 
            // textBoxInput_CVS
            // 
            this.textBoxInput_CVS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput_CVS.Location = new System.Drawing.Point(9, 99);
            this.textBoxInput_CVS.Multiline = true;
            this.textBoxInput_CVS.Name = "textBoxInput_CVS";
            this.textBoxInput_CVS.ReadOnly = true;
            this.textBoxInput_CVS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_CVS.Size = new System.Drawing.Size(476, 170);
            this.textBoxInput_CVS.TabIndex = 0;
            // 
            // openFileDialog_CVS
            // 
            this.openFileDialog_CVS.FileName = "openFileDialog1";
            // 
            // FormMain_CVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 519);
            this.Controls.Add(this.groupBoxOutPut_CVS);
            this.Controls.Add(this.groupBoxInPut_CVS);
            this.Controls.Add(this.groupBoxProperty_CVS);
            this.Controls.Add(this.panelButtons_CVS);
            this.MinimumSize = new System.Drawing.Size(1038, 575);
            this.Name = "FormMain_CVS";
            this.Text = "Спринт 6 | Таск 6 | Вариант 3 | Черепавнов В.С.";
            this.Load += new System.EventHandler(this.FormMain_CVS_Load);
            this.panelButtons_CVS.ResumeLayout(false);
            this.groupBoxProperty_CVS.ResumeLayout(false);
            this.groupBoxProperty_CVS.PerformLayout();
            this.groupBoxInPut_CVS.ResumeLayout(false);
            this.groupBoxInPut_CVS.PerformLayout();
            this.groupBoxOutPut_CVS.ResumeLayout(false);
            this.groupBoxOutPut_CVS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_CVS;
        private System.Windows.Forms.Button buttonOpenFile_CVS;
        private System.Windows.Forms.OpenFileDialog openFileDialogFindFile_CVS;
        private System.Windows.Forms.Button buttonFindSymbol_CVS;
        private System.Windows.Forms.ToolTip toolTipOpenFile_CVS;
        private System.Windows.Forms.ToolTip toolTipFindSymbol_CVS;
        private System.Windows.Forms.Button buttonInfo_CVS;
        private System.Windows.Forms.GroupBox groupBoxProperty_CVS;
        private System.Windows.Forms.TextBox textBoxProperty_CVS;
        private System.Windows.Forms.GroupBox groupBoxInPut_CVS;
        private System.Windows.Forms.GroupBox groupBoxOutPut_CVS;
        private System.Windows.Forms.TextBox textBoxOutput_CVS;
        private System.Windows.Forms.TextBox textBoxInput_CVS;
        private System.Windows.Forms.OpenFileDialog openFileDialog_CVS;
    }
}

