namespace wfaFormSDI
{
    public partial class FmMain : Form
    {
        private FmOptions fmOptions = new FmOptions();
        public FmMain()
        {
            InitializeComponent();

            buAbout.Click += (s, e) => new FmAbout().Show();
            button2.Click += (s, e) => new FmAbout().ShowDialog();
            button3.Click += (s, e) =>  fmOptions.ShowDialog();
        }


    }
}