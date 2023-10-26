namespace wfaGraphic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackgroundImageLayout = ImageLayout.None;
            this.Text += ":(Sin-red,Cos-green,Tan-blue";
            DrawAll();
            this.Resize += (s, e) => DrawAll();
        }

        private void DrawAll()
        {
            MyGraphic myGraphic = new(
                            this.ClientSize.Width,
                            this.ClientSize.Height);
            myGraphic.DrawAxes();
            myGraphic.DrawSin();
            myGraphic.DrawCos();
            myGraphic.DrawTan();

            this.BackgroundImage = (Bitmap)myGraphic.GetImage().Clone();
        }
    }
}