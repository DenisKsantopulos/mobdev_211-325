namespace wfaFileExplore
{
    public partial class Form1 : Form
    {
        public string CurDir { get; private set; }
        public Form1()
        {
            InitializeComponent();

            CurDir = "D:\\";
            LoadDir(CurDir);
        }
        
        private void LoadDir(string newDir)
        {
            DirectoryInfo directoryInfo = new(newDir);

            foreach (var item in directoryInfo.GetDirectories())
            {
                listView1.Items.Add(item.Name);
            }
            foreach (var item in directoryInfo.GetFiles())
            {
                listView1.Items.Add(item.Name);
            }

            CurDir = newDir;
        }
    }
}