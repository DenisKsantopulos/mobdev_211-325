namespace mauiCalculator
{
    internal class Calc
    {
        private double firstNumber;

        public string CurText { get; private set; }
        public string CurOper { get; private set; }

        public event EventHandler Changed;

        internal void Clear()
        {
            CurText = "";
            Changed?.Invoke(this, EventArgs.Empty);
        }

        internal void PressNum(int v)
        {
            CurText += v.ToString();
            Changed?.Invoke(this, EventArgs.Empty);
        }

        internal void PressOperator(string oper)
        {
            if (firstNumber != 0)
                    {
                //
            }
            double.TryParse(CurText, out firstNumber);
            CurOper = oper;
        }
    }
}