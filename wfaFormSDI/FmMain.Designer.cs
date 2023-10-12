namespace wfaFormSDI
{
    partial class FmMain
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
            buAbout = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // buAbout
            // 
            buAbout.Location = new Point(200, 33);
            buAbout.Name = "buAbout";
            buAbout.Size = new Size(230, 29);
            buAbout.TabIndex = 0;
            buAbout.Text = "about";
            buAbout.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(200, 78);
            button2.Name = "button2";
            button2.Size = new Size(198, 29);
            button2.TabIndex = 1;
            button2.Text = "dialog";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(58, 126);
            button3.Name = "button3";
            button3.Size = new Size(134, 29);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // FmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 453);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(buAbout);
            Name = "FmMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buAbout;
        private Button button2;
        private Button button3;
    }
}