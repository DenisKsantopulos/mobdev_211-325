namespace ImageViewer
{
    partial class FullSizeImage
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
            PicBoxImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicBoxImage).BeginInit();
            SuspendLayout();
            // 
            // PicBoxImage
            // 
            PicBoxImage.Dock = DockStyle.Fill;
            PicBoxImage.Location = new Point(0, 0);
            PicBoxImage.Name = "PicBoxImage";
            PicBoxImage.Size = new Size(800, 450);
            PicBoxImage.TabIndex = 0;
            PicBoxImage.TabStop = false;
            // 
            // FullSizeImage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PicBoxImage);
            Name = "FullSizeImage";
            Text = "FullSizeImage";
            ((System.ComponentModel.ISupportInitialize)PicBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicBoxImage;
    }
}