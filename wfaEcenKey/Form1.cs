namespace wfaEcenKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("enter pressed");
            }

            switch (e.KeyCode)
            {
                case Keys.Left:
                    laText.Text = "Left";
                    break;
                case Keys.Right:
                    laText.Text = "Right";
                    break;
                case Keys.Up:
                    laText.Text = "up";
                    break;
                case Keys.Space:
                    if (e.Shift)
                    {
                        laText.Text = "Shift + Space";
                    }
                    else
                    {
                        laText.Text = " Space";
                    }
                    break;
                case Keys.Z:
                    laText.Text = e.Shift ? "Shift + Z" : "Z";
                    break;
                default:
                    laText.Text = $"anth key={e.KeyCode}";
                    break;
            }
        }
    }
}