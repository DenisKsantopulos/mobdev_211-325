namespace ImageViewer
{
    public partial class Form1 : Form
    {
        private string curDir;

        public string CurDir
        {
            get => curDir;
            set
            {
                curDir = value;
                edDir.Text = curDir;
            }
        }

        public string SelectItem { get; private set; }

        public Form1()
        {
            InitializeComponent();

            CurDir = Directory.GetCurrentDirectory();

            buUp.Click += (s, e) => CurDir = DirManager.LoadDir(Directory.GetParent(CurDir)?.ToString(), listView1, CurDir);
            edDir.KeyDown += EdDir_KeyDown;

            listView1.View = View.LargeIcon;
            listView1.LargeImageList = DirManager.PrimaryCache;

            treeViewFolders.DoubleClick += TreeViewFolders_DoubleClick;

            listView1.ItemSelectionChanged += ListView1_ItemSelectionChanged;
            listView1.DoubleClick += ListView1_DoubleClick;

            treeViewFolders.Height = panel1.Height - pictureBoxPreview.Height;
            Resize += (s, e) => treeViewFolders.Height = panel1.Height - pictureBoxPreview.Height;

            splitter1.LocationChanged += Splitter2_LocationChanged;

            buDirSelect.Click += BuDirSelect_Click;

            TreeViewManager.Fill(treeViewFolders);
            DirManager.SetImageSize(50, 50);

            CurDir = DirManager.LoadDir(CurDir, listView1, CurDir);
        }

        private void SmallImgSize_Click(object? sender, EventArgs e)
        {
            DirManager.SetImageSize(25, 25);
        }

        private void Splitter2_LocationChanged(object? sender, EventArgs e)
        {
            if (pictureBoxPreview.Width > ClientSize.Height / 2)
            {
                pictureBoxPreview.Height = ClientSize.Height / 2;
            }
            else pictureBoxPreview.Height = pictureBoxPreview.Width;

            pictureBoxPreview.Dock = DockStyle.Bottom;
            treeViewFolders.Height = panel1.Height - pictureBoxPreview.Height;

            pictureBoxPreview.Update();
        }

        private void TreeViewFolders_DoubleClick(object? sender, EventArgs e)
        {
            DirectoryInfo directoryInfo = new(treeViewFolders.SelectedNode.FullPath);
            treeViewFolders.BeginUpdate();

            treeViewFolders.SelectedNode.Nodes.Clear();
            foreach (var item in directoryInfo.GetDirectories())
            {
                treeViewFolders.SelectedNode.Nodes.Add(treeViewFolders.SelectedNode.FullPath, item.Name, 0);
            }

            treeViewFolders.SelectedNode.Expand();
            treeViewFolders.EndUpdate();
            CurDir = DirManager.LoadDir(treeViewFolders.SelectedNode.FullPath, listView1, CurDir);
        }

        private void ListView1_DoubleClick(object? sender, EventArgs e)
        {
            CurDir = DirManager.Open(SelectItem, listView1, CurDir);
        }

        private void BuDirSelect_Click(object? sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                CurDir = DirManager.LoadDir(dialog.SelectedPath, listView1, CurDir);
            }
        }

        private void ListView1_ItemSelectionChanged(object? sender, ListViewItemSelectionChangedEventArgs e)
        {
            SelectItem = Path.Combine(CurDir, e.Item.Text);
            ImagePreviewer.ImagePreview(pictureBoxPreview, SelectItem);
        }

        private void EdDir_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CurDir = DirManager.LoadDir(edDir.Text, listView1, CurDir);
            }
        }
    }
}
