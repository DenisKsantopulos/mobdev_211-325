namespace wfFileExplorer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            buBack = new ToolStripButton();
            buForward = new ToolStripButton();
            buUp = new ToolStripButton();
            edDir = new ToolStripTextBox();
            buDirSelect = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            MItem = new ToolStripMenuItem();
            MItemIconS = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            laStatus = new ToolStripStatusLabel();
            panel1 = new Panel();
            listView1 = new ListView();
            ilLarge = new ImageList(components);
            ilSmall = new ImageList(components);
            splitter1 = new Splitter();
            treeView2 = new TreeView();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { buBack, buForward, buUp, edDir, buDirSelect, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(820, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // buBack
            // 
            buBack.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buBack.ImageTransparentColor = Color.Magenta;
            buBack.Name = "buBack";
            buBack.Size = new Size(29, 24);
            buBack.Text = "◀";
            // 
            // buForward
            // 
            buForward.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buForward.ImageTransparentColor = Color.Magenta;
            buForward.Name = "buForward";
            buForward.Size = new Size(29, 24);
            buForward.Text = "▶";
            // 
            // buUp
            // 
            buUp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buUp.ImageTransparentColor = Color.Magenta;
            buUp.Name = "buUp";
            buUp.Size = new Size(29, 24);
            buUp.Text = "▲";
            // 
            // edDir
            // 
            edDir.Name = "edDir";
            edDir.Size = new Size(500, 27);
            // 
            // buDirSelect
            // 
            buDirSelect.DisplayStyle = ToolStripItemDisplayStyle.Text;
            buDirSelect.ImageTransparentColor = Color.Magenta;
            buDirSelect.Name = "buDirSelect";
            buDirSelect.Size = new Size(29, 24);
            buDirSelect.Text = "...";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { MItem, MItemIconS, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItem6 });
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(49, 24);
            toolStripDropDownButton1.Text = "Вид";
            // 
            // MItem
            // 
            MItem.Name = "MItem";
            MItem.Size = new Size(100, 26);
            MItem.Text = "1";
            // 
            // MItemIconS
            // 
            MItemIconS.Name = "MItemIconS";
            MItemIconS.Size = new Size(100, 26);
            MItemIconS.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(100, 26);
            toolStripMenuItem4.Text = "3";
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(100, 26);
            toolStripMenuItem5.Text = "4";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(100, 26);
            toolStripMenuItem6.Text = "5";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { laStatus });
            statusStrip1.Location = new Point(0, 352);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(820, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // laStatus
            // 
            laStatus.Name = "laStatus";
            laStatus.Size = new Size(151, 20);
            laStatus.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(splitter1);
            panel1.Controls.Add(treeView2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(820, 325);
            panel1.TabIndex = 4;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.LargeImageList = ilLarge;
            listView1.Location = new Point(155, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(665, 325);
            listView1.SmallImageList = ilSmall;
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ilLarge
            // 
            ilLarge.ColorDepth = ColorDepth.Depth32Bit;
            ilLarge.ImageStream = (ImageListStreamer)resources.GetObject("ilLarge.ImageStream");
            ilLarge.TransparentColor = Color.Transparent;
            ilLarge.Images.SetKeyName(0, "folder.png");
            ilLarge.Images.SetKeyName(1, "file.png");
            // 
            // ilSmall
            // 
            ilSmall.ColorDepth = ColorDepth.Depth32Bit;
            ilSmall.ImageStream = (ImageListStreamer)resources.GetObject("ilSmall.ImageStream");
            ilSmall.TransparentColor = Color.Transparent;
            ilSmall.Images.SetKeyName(0, "folder.png");
            ilSmall.Images.SetKeyName(1, "file.png");
            // 
            // splitter1
            // 
            splitter1.Location = new Point(151, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 325);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // treeView2
            // 
            treeView2.Dock = DockStyle.Left;
            treeView2.ImageIndex = 0;
            treeView2.ImageList = ilSmall;
            treeView2.Location = new Point(0, 0);
            treeView2.Name = "treeView2";
            treeView2.SelectedImageIndex = 0;
            treeView2.Size = new Size(151, 325);
            treeView2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 378);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "wfFileExplorer";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton buBack;
        private ToolStripButton buForward;
        private ToolStripButton buUp;
        private ToolStripTextBox edDir;
        private ToolStripButton buDirSelect;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private StatusStrip statusStrip1;
        private Panel panel1;
        private TreeView treeView2;
        private Splitter splitter1;
        private ListView listView1;
        private ImageList ilLarge;
        private ImageList ilSmall;
        private ToolStripMenuItem MItem;
        private ToolStripMenuItem MItemIconS;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripStatusLabel laStatus;
    }
}