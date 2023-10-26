namespace wfaGraphic
{
    internal class MyGraphic
    {
        public MyGraphic(int width, int height)
        {
            Width = width;
            Height = height;

            b = new Bitmap(width, height);
            g = Graphics.FromImage(b);

            grShifty=b.Height/2;
            gHeight = grShifty*0.9;
            grWidthPI = Math.PI / b.Width;
        }

        public int Width { get; }
        public int Height { get; }
        public int CountWave { get; } = 5;
        public int DotDiametr { get; } = 4;

        private Bitmap b;
        private Graphics g;
        private int grShifty;
        private double gHeight;
        private double grWidthPI;

        internal void DrawAxes()
        {
            //OX
            //c.DrawLine(new Pen(Color.Black),0,grShifty,b.Width,grShifty);
            g.DrawLine(Pens.Black,0,grShifty,b.Width,grShifty);
            for(int i = 0; i < CountWave; i++)
            {
                var _x = b.Width / CountWave * i;
                g.DrawLine(Pens.DarkGoldenrod, _x, 0, _x, b.Height);
                //g.DrawLine(Pens.DarkGoldenrod, _x, grShifty-20, _x, b.Height+20);
            }
            //OY
            g.DrawLine(Pens.Black, 0, 0, 0, b.Height);
        }

        internal Bitmap? GetImage()
        {
            return b;
        }

        internal void DrawSin()
        {
            double _x;
            double _y;
            for (int i = 0;i < b.Width; i++)
            {
                _x = i;
                _y = grShifty * -Math.Sin(_x * CountWave * grWidthPI)+grShifty;
                g.FillEllipse(new SolidBrush(Color.RebeccaPurple),
                    (int)_x - DotDiametr / 2, (int)_y - DotDiametr / 2,DotDiametr,DotDiametr);
            }

        }

        internal void DrawCos()
        {
            double _x;
            double _y;
            for (int i = 0; i < b.Width; i++)
            {
                _x = i;
                _y = grShifty * -Math.Cos(_x * CountWave * grWidthPI) + grShifty;
                g.FillEllipse(new SolidBrush(Color.GreenYellow),
                    (int)_x - DotDiametr / 2, (int)_y - DotDiametr / 2, DotDiametr, DotDiametr);
            }
        }

        internal void DrawTan()
        {
            double _x;
            double _y;
            for (int i = 0; i < b.Width; i++)
            {
                _x = i;
                _y = grShifty * -Math.Tan(_x * CountWave * grWidthPI) + grShifty;
                if (_y>0 && _y < b.Height)
                {
                    g.FillEllipse(new SolidBrush(Color.BlueViolet),
                    (int)_x - DotDiametr / 2, (int)_y - DotDiametr / 2, DotDiametr, DotDiametr);
                }
                
            }
        }
    }
}