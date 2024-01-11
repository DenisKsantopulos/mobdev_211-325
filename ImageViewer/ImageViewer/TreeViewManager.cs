namespace ImageViewer
{
    internal class TreeViewManager
    {
        internal static void Fill(TreeView treeViewFolders)
        {
            foreach (var drive in Directory.GetLogicalDrives())
            {
                treeViewFolders.Nodes.Add(drive);
            }
        }
    }
}