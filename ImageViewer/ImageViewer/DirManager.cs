using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ImageViewer
{
    internal class DirManager
    {
        public static ImageList PrimaryCache = new(); // clears every time there is a folder transition (binded to listView)
        private static ImageList largeFilesСache = new(); // stores large files and is cleared if the memory limit is exceeded

        static Bitmap iconForFile;

        private static readonly HashSet<string> validExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            ".png",
            ".jpg",
            ".bmp"
        };

        internal static bool IsPictureExt(string ext)
        {
            return validExtensions.Contains(ext);
        }

        public static void SetImageSize(int width, int height)
        {
            Size size = new(width, height);
            PrimaryCache.ImageSize = size;
            largeFilesСache.ImageSize = size;

        }

        internal static string LoadDir(string? newDir, ListView listView1, string curDir)
        {
            if (newDir == null || newDir == "")
                return curDir;

            DirectoryInfo dir = new(newDir);
            if (!dir.Exists)
            {
                MessageBox.Show("Неверно указана директория!");
                return curDir;
            }

            listView1.BeginUpdate();

            //PrimaryCache.Images.Clear();
            listView1.Items.Clear();

            foreach (var item in dir.GetDirectories())
            {
                listView1.Items.Add(
                    new ListViewItem(new string[] { item.Name, item.LastWriteTime.ToString(), "file" }, 0));
            }

            foreach (var file in dir.GetFiles())
            {
                if (!IsPictureExt(file.Extension))
                    continue;

                ListViewItem newItem = new ListViewItem(file.Name, 1);


                if (!PrimaryCache.Images.ContainsKey(file.FullName))
                {
                    iconForFile = new(file.FullName);  //iconForFile = ResizeImage(Image.FromFile(file.FullName), 50, 50);

                    largeFilesСache.Images.Add(file.FullName, iconForFile);
                    PrimaryCache.Images.Add(file.FullName, iconForFile);

                    iconForFile.Dispose();

                }
                newItem.ImageKey = file.FullName;
                listView1.Items.Add(newItem);
            }

            listView1.EndUpdate();

            return newDir;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.Low;
                graphics.SmoothingMode = SmoothingMode.HighSpeed;
                graphics.PixelOffsetMode = PixelOffsetMode.None;
                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
                image.Dispose();
                graphics.Dispose();
            }
            return destImage;
        }

        internal static string Open(string newDir, ListView listView1, string curDir)
        {
            FileInfo file = new(newDir);

            if (file.Exists)
            {
                if (!IsPictureExt(file.Extension))
                    return curDir;

                ImagePreviewer.PicturePath = newDir;

                FullSizeImage dlg = new();
                dlg.ShowDialog();
            }
            else curDir = LoadDir(newDir, listView1, curDir);

            return curDir;
        }
    }
}