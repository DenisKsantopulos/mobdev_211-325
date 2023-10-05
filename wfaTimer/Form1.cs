namespace wfaTimer
{
    public partial class Form1 : Form
    {
        private const int SEC_MAX = 10;
        private System.Windows.Forms.Timer tmUp = new();
        private System.Windows.Forms.Timer tmDown = new();
        private DateTime startTimeUp;
        private DateTime pauseTimeUp;

        public Form1()
        {
            InitializeComponent();

            tmUp.Interval = 100; // 1 сек = 1000
            tmUp.Tick += TmUp_Tick;
            buUp.Click += BuUp_Click;
            buUpPause.Click += BuUpPause_Click;
            pbUp.Maximum = SEC_MAX;
            pbUpMs.Maximum = SEC_MAX + 1000;
        }

        private void BuUpPause_Click(object? sender, EventArgs e)
        {
            if (pbUp.Enabled)
            {
                pauseTimeUp = DateTime.Now;
                tmUp.Stop();
            }
            else
            {
                startTimeUp = startTimeUp + (DateTime.Now - pauseTimeUp);
                tmUp.Start();
            }
        }

        private void BuUp_Click(object? sender, EventArgs e)
        {
            tmUp.Enabled = !tmUp.Enabled;
            startTimeUp = DateTime.Now;
        }

        private void TmUp_Tick(object? sender, EventArgs e)
        {
            // 1
            //buUp.Text = (DateTime.Now - startTimeUp).ToString(@"hh\:mm\:ss\.fff");

            // 2
            var x = DateTime.Now - startTimeUp;
            if (x.TotalSeconds > SEC_MAX)
            {
                tmUp.Stop();
                x = TimeSpan.FromSeconds(SEC_MAX);
            }
            buUp.Text = x.ToString(@"hh\:mm\:ss\.fff");
            pbUp.Value = (int)x.TotalSeconds;
            pbUpMs.Value = (int)x.TotalMilliseconds;
        }
    }
}