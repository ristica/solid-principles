namespace Lsp_Start.Core
{
    public class AreaCalculator
    {
        public static int CalculateArea(Rectangle r)
        {
            return r.Height * r.Width;
        }

        public static int CalculateArea(Square s)
        {
            return s.Height * s.Height;
        }
    }

    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }

    public class Square : Rectangle
    {
        private int _height;
        private int _width;

        public override int Height
        {
            get { return this._height; }
            set
            {
                this._height = value;
                this._width = value;
            }
        }
        public override int Width
        {
            get { return this._width; }
            set
            {
                this._height = value;
                this._width = value;
            }
        }

    }
}
