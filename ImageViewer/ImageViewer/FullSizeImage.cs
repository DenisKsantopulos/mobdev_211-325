using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class FullSizeImage : Form
    {
        private Bitmap img;

        public FullSizeImage()
        {
            InitializeComponent();

            Text = ImagePreviewer.PicturePath;

            img = new Bitmap(ImagePreviewer.PicturePath);
            PicBoxImage.Image = img;
            Size = img.Size;
            PicBoxImage.SizeMode = PictureBoxSizeMode.StretchImage;

            FormClosing += FullSizeImage_FormClosing;
        }

        private void FullSizeImage_FormClosing(object? sender, FormClosingEventArgs e)
        {
            img.Dispose();
        }
    }
}
