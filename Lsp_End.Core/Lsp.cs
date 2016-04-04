namespace Lsp_End.Core
{
    public class Lsp
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
                return this.Width * this.Height;
            }
        }

        public class Square : Shape
        {
            public int Sidelength { private get; set; }

            public override int CalculateArea()
            {
                return this.Sidelength * this.Sidelength;
            }
        }
    }
}
