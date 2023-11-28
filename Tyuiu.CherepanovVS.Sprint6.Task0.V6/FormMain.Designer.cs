
namespace Tyuiu.CherepanovVS.Sprint6.Task0.V6
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
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupIF = new System.Windows.Forms.GroupBox();
            this.pictureBoxPicture = new System.Windows.Forms.PictureBox();
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.textBoxVarA = new System.Windows.Forms.TextBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.textBoxVarAname = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupIF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).BeginInit();
            this.groupMenu.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(611, 385);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(161, 53);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupIF
            // 
            this.groupIF.Controls.Add(this.textBoxTask);
            this.groupIF.Controls.Add(this.pictureBoxPicture);
            this.groupIF.Location = new System.Drawing.Point(22, 62);
            this.groupIF.Name = "groupIF";
            this.groupIF.Size = new System.Drawing.Size(750, 187);
            this.groupIF.TabIndex = 1;
            this.groupIF.TabStop = false;
            this.groupIF.Text = "Условие";
            // 
            // pictureBoxPicture
            // 
            this.pictureBoxPicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPicture.Image")));
            this.pictureBoxPicture.Location = new System.Drawing.Point(520, 45);
            this.pictureBoxPicture.Name = "pictureBoxPicture";
            this.pictureBoxPicture.Size = new System.Drawing.Size(199, 89);
            this.pictureBoxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPicture.TabIndex = 0;
            this.pictureBoxPicture.TabStop = false;
            // 
            // groupMenu
            // 
            this.groupMenu.Controls.Add(this.textBoxVarAname);
            this.groupMenu.Controls.Add(this.textBoxVarA);
            this.groupMenu.Location = new System.Drawing.Point(22, 277);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.Size = new System.Drawing.Size(470, 149);
            this.groupMenu.TabIndex = 2;
            this.groupMenu.TabStop = false;
            this.groupMenu.Text = "Ввод данных";
            this.groupMenu.Enter += new System.EventHandler(this.groupMenu_Enter);
            // 
            // textBoxVarA
            // 
            this.textBoxVarA.Location = new System.Drawing.Point(22, 86);
            this.textBoxVarA.Multiline = true;
            this.textBoxVarA.Name = "textBoxVarA";
            this.textBoxVarA.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxVarA.Size = new System.Drawing.Size(148, 26);
            this.textBoxVarA.TabIndex = 0;
            this.textBoxVarA.TextChanged += new System.EventHandler(this.textBoxVarA_TextChanged);
            this.textBoxVarA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarA_KeyPress);
            // 
            // textBoxTask
            // 
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Location = new System.Drawing.Point(22, 35);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(492, 126);
            this.textBoxTask.TabIndex = 1;
            this.textBoxTask.Text = "Вычислить выражение по формуле";
            this.textBoxTask.TextChanged += new System.EventHandler(this.textBoxCondition_TextChanged);
            // 
            // textBoxVarAname
            // 
            this.textBoxVarAname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxVarAname.Location = new System.Drawing.Point(22, 44);
            this.textBoxVarAname.Multiline = true;
            this.textBoxVarAname.Name = "textBoxVarAname";
            this.textBoxVarAname.ReadOnly = true;
            this.textBoxVarAname.Size = new System.Drawing.Size(148, 26);
            this.textBoxVarAname.TabIndex = 1;
            this.textBoxVarAname.Text = "Переменная A:";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBoxResult2);
            this.groupBoxResult.Controls.Add(this.textBoxResult);
            this.groupBoxResult.Location = new System.Drawing.Point(521, 265);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(251, 114);
            this.groupBoxResult.TabIndex = 3;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Location = new System.Drawing.Point(16, 34);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 26);
            this.textBoxResult.TabIndex = 0;
            this.textBoxResult.Text = "Результат:";
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult2.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxResult2.Location = new System.Drawing.Point(16, 66);
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.ReadOnly = true;
            this.textBoxResult2.Size = new System.Drawing.Size(219, 26);
            this.textBoxResult2.TabIndex = 1;
            // 
            // buttonHelp
            // 
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Location = new System.Drawing.Point(551, 385);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(54, 53);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupMenu);
            this.Controls.Add(this.groupIF);
            this.Controls.Add(this.buttonDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 6 | Черепанов В.С.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupIF.ResumeLayout(false);
            this.groupIF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicture)).EndInit();
            this.groupMenu.ResumeLayout(false);
            this.groupMenu.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupIF;
        private System.Windows.Forms.PictureBox pictureBoxPicture;
        private System.Windows.Forms.GroupBox groupMenu;
        private System.Windows.Forms.TextBox textBoxVarA;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.TextBox textBoxVarAname;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.TextBox textBoxResult2;
    }
}

