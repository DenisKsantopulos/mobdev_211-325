namespace consolEnum
{
    internal class Program
    {
        public enum SingleColor { Red, Green, Blue=100300, White }

        
        public enum MultiColor : byte { 
            Red=1,     //ob.0000.0001
            Green=2,   //ob.0000.0010
            Blue=4    //ob.0000.0100
        }

        static void Main(string[] args)
        {
            SingleColor singleColor = SingleColor.Red;
            Console.WriteLine(singleColor);
            Console.WriteLine(singleColor.ToString("D"));
            singleColor = SingleColor.Blue;
            Console.WriteLine(singleColor.ToString("D"));

            MultiColor multiColor = MultiColor.Red;
            multiColor |= MultiColor.Blue;
            Console.WriteLine(multiColor);
            //multiColor ^= MultiColor.Blue;
            //Console.WriteLine(multiColor);

            Console.WriteLine(multiColor==MultiColor.Red);
            Console.WriteLine(multiColor.HasFlag(MultiColor.Red));


        }
    }
}