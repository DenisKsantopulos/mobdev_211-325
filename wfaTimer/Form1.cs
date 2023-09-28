namespace wfaTimer
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer tmUp = new();
        private System.Windows.Forms.Timer tmDown = new();
        public Form1()
        {
            InitializeComponent();

            tmUp.Interval = 100;
            tmUp.Tick += TmUp_Tick;
        }

        private void TmUp_Tick(object? sender, EventArgs e)
        {
            //
        }
    }
}