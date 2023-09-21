namespace Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += ButtonAll_Click;
            button1.Click += ButtonAll_Click;
            checkBox1.Click += ButtonAll_Click;
            label1.Click += ButtonAll_Click;
            
        }

        private void ButtonAll_Click(object? sender, EventArgs e)
        {
            //Button button = (Button)sender;
            //MessageBox.Show(button.Text);

            //if (sender is Button)
            //    MessageBox.Show(((Button)sender).Text);

            if (sender is Control c)
                MessageBox.Show(c.Text);

            (sender as Control).Text +="*";
        }
    }
}