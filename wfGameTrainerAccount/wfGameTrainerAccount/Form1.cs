namespace wfGameTrainerAccount
{
    public partial class Form1 : Form
    {
        private readonly Game game;
        public Form1()
        {
            InitializeComponent();

            game = new();
            game.DoReset();
            game.Change += Game_Change;

            btnYes.Click += (s, e) => game.DoAnswer(true);
            btnNo.Click += (s, e) => game.DoAnswer(false);
        }

        private void Game_Change(object? sender, EventArgs e)
        {
            laCorrect.Text=$"Верно = {game.CountCorrect}";
            laWrong.Text=$"Неверно = {game.CountWrong}";
            laCode.Text = game.CodeText;
        }
    }
}