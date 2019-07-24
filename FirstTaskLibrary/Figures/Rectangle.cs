namespace FirstTaskLibrary
{
    public class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}

