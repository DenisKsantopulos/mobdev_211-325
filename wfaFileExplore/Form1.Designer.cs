namespace wfaFileExplore
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
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripButton4 = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            panel1 = new Panel();
            treeView1 = new TreeView();
            splitter1 = new Splitter();
            listView1 = new ListView();
            ilLarge = new ImageList(components);
            ilSmall = new ImageList(components);
            statusStrip1 = new StatusStrip();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripButton3, toolStripTextBox1, toolStripButton4, toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "←";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "→";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "↑";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(500, 27);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 24);
            toolStripButton4.Text = "…";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(49, 24);
            toolStripDropDownButton1.Text = "Вид";
            // 
            // panel1
            // 
            panel1.Controls.Add(treeView1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(278, 423);
            panel1.TabIndex = 2;
            // 
            // treeView1
            // 
            treeView1.Dock = DockStyle.Fill;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(278, 423);
            treeView1.TabIndex = 2;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(278, 27);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 423);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // listView1
            // 
            listView1.Dock = DockStyle.Fill;
            listView1.LargeImageList = ilLarge;
            listView1.Location = new Point(282, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(518, 423);
            listView1.SmallImageList = ilSmall;
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ilLarge
            // 
            ilLarge.ColorDepth = ColorDepth.Depth8Bit;
            ilLarge.ImageStream = (ImageListStreamer)resources.GetObject("ilLarge.ImageStream");
            ilLarge.TransparentColor = Color.Transparent;
            ilLarge.Images.SetKeyName(0, "3767084.png");
            ilLarge.Images.SetKeyName(1, "png-transparent-computer-icons-document-file-format-others-angle-text-rectangle.png");
            // 
            // ilSmall
            // 
            ilSmall.ColorDepth = ColorDepth.Depth8Bit;
            ilSmall.ImageStream = (ImageListStreamer)resources.GetObject("ilSmall.ImageStream");
            ilSmall.TransparentColor = Color.Transparent;
            ilSmall.Images.SetKeyName(0, "3767084.png");
            ilSmall.Images.SetKeyName(1, "png-transparent-computer-icons-document-file-format-others-angle-text-rectangle.png");
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(282, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(518, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(listView1);
            Controls.Add(splitter1);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton toolStripButton4;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private Panel panel1;
        private TreeView treeView1;
        private Splitter splitter1;
        private ListView listView1;
        private ImageList ilLarge;
        private ImageList ilSmall;
        private StatusStrip statusStrip1;
    }
}