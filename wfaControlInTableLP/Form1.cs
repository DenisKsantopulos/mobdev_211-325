namespace wfaControlInTableLP
{
    public partial class WFA : Form
    {
        public WFA()
        {
            InitializeComponent();
            //pictureBox1.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox2.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox3.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox4.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox5.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox6.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox7.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox8.MouseEnter += PictureBoxAll_MouseEnter;
            //pictureBox9.MouseEnter += PictureBoxAll_MouseEnter;

            //pictureBox1.MouseLeave += PictureBoxAll_MouseEnter;
            //pictureBox2.MouseLeave += PictureBoxAll_MouseEnter;
            //pictureBox3.MouseLeave += PictureBoxAll_MouseEnter;
            //pictureBox4.MouseLeave += PictureBoxAll_MouseEnter;
            //pictureBox5.MouseLeave += PictureBoxAll_MouseEnter;
            //pictureBox6.MouseLeave += PictureBoxAll_MouseEnter;
            //pictureBox7.MouseLeave += PictureBoxAll_MouseEnter;
            //pictureBox8.MouseLeave += PictureBoxAll_MouseEnter;
            //pictureBox9.MouseLeave += PictureBoxAll_MouseEnter;

            //pictureBox1.Tag = 1;
            //pictureBox2.Tag = 1;
            //pictureBox3.Tag = 1;
            //pictureBox4.Tag = 1;
            //pictureBox5.Tag = 1;
            //pictureBox6.Tag = 1;
            //pictureBox7.Tag = 1;
            //pictureBox8.Tag = 1;
            //pictureBox9.Tag = 1;

            // 2

            List<PictureBox> list = new();
            {
                list.Add(pictureBox1);
                list.Add(pictureBox2);
                list.Add(pictureBox3);
                list.Add(pictureBox4);
                list.Add(pictureBox5);
                list.Add(pictureBox6);
                list.Add(pictureBox7);
                list.Add(pictureBox8);
                list.Add(pictureBox9);
            };

            int n = 1;
            foreach (var item in list)
            {
                item.MouseEnter += PictureBoxAll_MouseEnter;
                item.MouseLeave += PictureBoxAll_MouseLeave;
                item.MouseClick += PictureBoxAll_MouseClick;
                item.Tag = n++;
                item.Image = imageList1.Images[0];
                item.SizeMode = PictureBoxSizeMode.Zoom;
            }


        }

        private void PictureBoxAll_MouseClick(object? sender, MouseEventArgs e)
        {

            if (sender is PictureBox px)
            {
                switch (e.Button)
                {
                    case MouseButtons.Left:
                        px.BorderStyle = px.BorderStyle == BorderStyle.None ? BorderStyle.FixedSingle : BorderStyle.None;
                        break;
                    case MouseButtons.Right:
                        px.BackColor = px.BackColor == SystemColors.Control ? Color.LightBlue : SystemColors.Control;
                        break;
                }
            }
        }
        private void PictureBoxAll_MouseLeave(object? sender, EventArgs e)
        {

            if (sender is PictureBox pictureBox)
            {
                pictureBox.Image = imageList1.Images[0];
            }
        }

        private void PictureBoxAll_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                pictureBox.Image = imageList1.Images[Convert.ToInt32(pictureBox.Tag)];
            }
        } 

        
    }
}