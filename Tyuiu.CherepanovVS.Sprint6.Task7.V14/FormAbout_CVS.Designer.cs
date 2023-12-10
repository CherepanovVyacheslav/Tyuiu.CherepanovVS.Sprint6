
namespace Tyuiu.CherepanovVS.Sprint6.Task7.V14
{
    partial class FormAbout_CVS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_CVS));
            this.buttonAvtorOK_CVS = new System.Windows.Forms.Button();
            this.textBoxAvtorInfo_CVS = new System.Windows.Forms.TextBox();
            this.pictureBoxAvtorInfo_CVS = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvtorInfo_CVS)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAvtorOK_CVS
            // 
            this.buttonAvtorOK_CVS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAvtorOK_CVS.Location = new System.Drawing.Point(525, 232);
            this.buttonAvtorOK_CVS.Name = "buttonAvtorOK_CVS";
            this.buttonAvtorOK_CVS.Size = new System.Drawing.Size(128, 42);
            this.buttonAvtorOK_CVS.TabIndex = 5;
            this.buttonAvtorOK_CVS.Text = "OK";
            this.buttonAvtorOK_CVS.UseVisualStyleBackColor = true;
            this.buttonAvtorOK_CVS.Click += new System.EventHandler(this.buttonAvtorOK_CVS_Click);
            // 
            // textBoxAvtorInfo_CVS
            // 
            this.textBoxAvtorInfo_CVS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAvtorInfo_CVS.Location = new System.Drawing.Point(239, 12);
            this.textBoxAvtorInfo_CVS.Multiline = true;
            this.textBoxAvtorInfo_CVS.Name = "textBoxAvtorInfo_CVS";
            this.textBoxAvtorInfo_CVS.ReadOnly = true;
            this.textBoxAvtorInfo_CVS.Size = new System.Drawing.Size(418, 197);
            this.textBoxAvtorInfo_CVS.TabIndex = 4;
            this.textBoxAvtorInfo_CVS.Text = resources.GetString("textBoxAvtorInfo_CVS.Text");
            // 
            // pictureBoxAvtorInfo_CVS
            // 
            this.pictureBoxAvtorInfo_CVS.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvtorInfo_CVS.Image")));
            this.pictureBoxAvtorInfo_CVS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAvtorInfo_CVS.Name = "pictureBoxAvtorInfo_CVS";
            this.pictureBoxAvtorInfo_CVS.Size = new System.Drawing.Size(211, 262);
            this.pictureBoxAvtorInfo_CVS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvtorInfo_CVS.TabIndex = 3;
            this.pictureBoxAvtorInfo_CVS.TabStop = false;
            this.pictureBoxAvtorInfo_CVS.Click += new System.EventHandler(this.pictureBoxAvtorInfo_CVS_Click);
            // 
            // FormAbout_CVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 289);
            this.Controls.Add(this.buttonAvtorOK_CVS);
            this.Controls.Add(this.textBoxAvtorInfo_CVS);
            this.Controls.Add(this.pictureBoxAvtorInfo_CVS);
            this.Name = "FormAbout_CVS";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvtorInfo_CVS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAvtorOK_CVS;
        private System.Windows.Forms.TextBox textBoxAvtorInfo_CVS;
        private System.Windows.Forms.PictureBox pictureBoxAvtorInfo_CVS;
    }
}