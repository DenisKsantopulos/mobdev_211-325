﻿namespace wfaTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buUp = new Button();
            buUpPause = new Button();
            pbUp = new ProgressBar();
            pbUpMs = new ProgressBar();
            SuspendLayout();
            // 
            // buUp
            // 
            buUp.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            buUp.Location = new Point(12, 15);
            buUp.Name = "buUp";
            buUp.Size = new Size(324, 93);
            buUp.TabIndex = 0;
            buUp.Text = "00:00:000";
            buUp.UseVisualStyleBackColor = true;
            // 
            // buUpPause
            // 
            buUpPause.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buUpPause.Location = new Point(342, 15);
            buUpPause.Name = "buUpPause";
            buUpPause.Size = new Size(98, 93);
            buUpPause.TabIndex = 1;
            buUpPause.Text = "Pause";
            buUpPause.UseVisualStyleBackColor = true;
            // 
            // pbUp
            // 
            pbUp.Location = new Point(487, 18);
            pbUp.Name = "pbUp";
            pbUp.Size = new Size(372, 29);
            pbUp.TabIndex = 2;
            // 
            // pbUpMs
            // 
            pbUpMs.Location = new Point(487, 79);
            pbUpMs.Maximum = 10;
            pbUpMs.Name = "pbUpMs";
            pbUpMs.Size = new Size(372, 29);
            pbUpMs.Step = 100;
            pbUpMs.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 208);
            Controls.Add(pbUpMs);
            Controls.Add(pbUp);
            Controls.Add(buUpPause);
            Controls.Add(buUp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buUp;
        private Button buUpPause;
        private ProgressBar pbUp;
        private ProgressBar pbUpMs;
    }
}