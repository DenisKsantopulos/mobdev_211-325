namespace ImageViewer
{
    internal class ImagePreviewer
    {
        internal static string PicturePath { get; set; }

        internal static void ImagePreview(PictureBox pictureBoxPreviewer, string selectItemPath)
        {
            string ext = Path.GetExtension(selectItemPath);

            if (!DirManager.IsPictureExt(ext))
                return;

            if ((string?)pictureBoxPreviewer.Tag == "photo") pictureBoxPreviewer.Image.Dispose();

            pictureBoxPreviewer.Tag = "photo";
            pictureBoxPreviewer.Image = Image.FromFile(selectItemPath);
            pictureBoxPreviewer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPreviewer.Refresh();
        }
    }
}