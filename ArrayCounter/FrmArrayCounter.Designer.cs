namespace ArrayCounter
{
    partial class FrmArrayCounter
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
            this.BtnCount = new System.Windows.Forms.Button();
            this.LstInfo = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LstFrequency = new System.Windows.Forms.ListBox();
            this.BtnStudentMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCount
            // 
            this.BtnCount.Location = new System.Drawing.Point(261, 28);
            this.BtnCount.Name = "BtnCount";
            this.BtnCount.Size = new System.Drawing.Size(151, 28);
            this.BtnCount.TabIndex = 0;
            this.BtnCount.Text = "Determine Mark Frequency";
            this.BtnCount.UseVisualStyleBackColor = true;
            this.BtnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // LstInfo
            // 
            this.LstInfo.FormattingEnabled = true;
            this.LstInfo.HorizontalScrollbar = true;
            this.LstInfo.Location = new System.Drawing.Point(25, 96);
            this.LstInfo.Name = "LstInfo";
            this.LstInfo.ScrollAlwaysVisible = true;
            this.LstInfo.Size = new System.Drawing.Size(290, 160);
            this.LstInfo.TabIndex = 1;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(318, 349);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(56, 23);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LstFrequency
            // 
            this.LstFrequency.FormattingEnabled = true;
            this.LstFrequency.Location = new System.Drawing.Point(360, 95);
            this.LstFrequency.Name = "LstFrequency";
            this.LstFrequency.Size = new System.Drawing.Size(126, 82);
            this.LstFrequency.TabIndex = 3;
            // 
            // BtnStudentMark
            // 
            this.BtnStudentMark.Location = new System.Drawing.Point(261, 289);
            this.BtnStudentMark.Name = "BtnStudentMark";
            this.BtnStudentMark.Size = new System.Drawing.Size(150, 25);
            this.BtnStudentMark.TabIndex = 4;
            this.BtnStudentMark.Text = "Student´s Mark";
            this.BtnStudentMark.UseVisualStyleBackColor = true;
            this.BtnStudentMark.Click += new System.EventHandler(this.BtnStudentMark_Click);
            // 
            // FrmArrayCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 424);
            this.Controls.Add(this.BtnStudentMark);
            this.Controls.Add(this.LstFrequency);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.LstInfo);
            this.Controls.Add(this.BtnCount);
            this.Name = "FrmArrayCounter";
            this.Text = "Demo of Array Counters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCount;
        private System.Windows.Forms.ListBox LstInfo;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ListBox LstFrequency;
        private System.Windows.Forms.Button BtnStudentMark;
    }
}

