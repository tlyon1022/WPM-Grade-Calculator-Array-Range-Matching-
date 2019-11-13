namespace Lab6
{
    partial class Form1
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
            this.promptLbl = new System.Windows.Forms.Label();
            this.wpmTxt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.gradeLbl = new System.Windows.Forms.Label();
            this.gradeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // promptLbl
            // 
            this.promptLbl.AutoSize = true;
            this.promptLbl.Location = new System.Drawing.Point(12, 40);
            this.promptLbl.Name = "promptLbl";
            this.promptLbl.Size = new System.Drawing.Size(146, 17);
            this.promptLbl.TabIndex = 0;
            this.promptLbl.Text = "Enter your best WPM:";
            // 
            // wpmTxt
            // 
            this.wpmTxt.Location = new System.Drawing.Point(177, 37);
            this.wpmTxt.Name = "wpmTxt";
            this.wpmTxt.Size = new System.Drawing.Size(100, 22);
            this.wpmTxt.TabIndex = 1;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(98, 83);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(139, 23);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Grade Calculation";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.CalcBtn_Click);
            // 
            // gradeLbl
            // 
            this.gradeLbl.AutoSize = true;
            this.gradeLbl.Location = new System.Drawing.Point(12, 161);
            this.gradeLbl.Name = "gradeLbl";
            this.gradeLbl.Size = new System.Drawing.Size(56, 17);
            this.gradeLbl.TabIndex = 3;
            this.gradeLbl.Text = "Grade: ";
            // 
            // gradeOutput
            // 
            this.gradeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeOutput.Location = new System.Drawing.Point(174, 161);
            this.gradeOutput.Name = "gradeOutput";
            this.gradeOutput.Size = new System.Drawing.Size(100, 23);
            this.gradeOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AcceptButton = this.calcBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 215);
            this.Controls.Add(this.gradeOutput);
            this.Controls.Add(this.gradeLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.wpmTxt);
            this.Controls.Add(this.promptLbl);
            this.Name = "Form1";
            this.Text = "Lab 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label promptLbl;
        private System.Windows.Forms.TextBox wpmTxt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label gradeLbl;
        private System.Windows.Forms.Label gradeOutput;
    }
}

