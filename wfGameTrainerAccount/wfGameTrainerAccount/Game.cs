namespace wfGameTrainerAccount
{
    internal class Game
    {
        private Random rnd = new Random();
        public int CountCorrect { get; private set; }
        public int CountWrong { get; private set; }
        public string? CodeText { get; private set; }

        private bool answerCorrect;
        private int maxValue=20;

        public event EventHandler Change;

        public void DoReset()
        {
            CountCorrect = 0;
            CountWrong = 0;
            DoContinue();
        }

        private void DoContinue()
        {
            //CodeText = "11 + 22 = 33";
            //answerCorrect = true;
            int value1=rnd.Next(maxValue);
            int value2=rnd.Next(maxValue);
            int result=value1+value2;
            int resultNew = result;
            if (rnd.Next(2) == 1) {
                resultNew += rnd.Next(1,7)*(rnd.Next(2)==1? 1:-1);
            }
            CodeText = $"{value1}+{value2}={resultNew}";
            answerCorrect = (result==resultNew);
            Change?.Invoke(this, EventArgs.Empty);
        }

        public void DoAnswer(bool v)
        {
            if(v ==  answerCorrect)
                CountCorrect++;
            else CountWrong++;

            DoContinue();
        }
    }
}