namespace Lsp_End.Core
{
    public static class Lsp
    {
        public abstract class Shape
        {
            public abstract int CalculateArea();
        }

        public class Rectangle : Shape
        {
            public int Height { private get; set; }
            public int Width { private get; set; }

            public override int CalculateArea()
            {
                return Width * Height;
            }
        }

        public class Square : Shape
        {
            public int SideLength { private get; set; }

            public override int CalculateArea()
            {
                return SideLength * SideLength;
            }
        }
    }
}