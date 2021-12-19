using System;
using System.Text;

namespace OOShape
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        
       
        public double Area { get; set; }
        public double Perimeter { get; set; }

        public Rectangle()
        {
        }

        public Rectangle(int width, int height) : this(width)
        {
            //Width = width;
            Height = height;
        }

        public Rectangle(int equalSides)
        {
            Width = equalSides;
            Height = equalSides;
        }

        public override double GetArea()
        {
            Area = Width * Height;
            return Area;
        }

        public override double GetPerimeter()
        {
            Perimeter = 2 * (Width + Height);
            return Perimeter;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"This is rectangle with height {Height} and width {Width}. Area is {GetArea()} and perimeter is {GetPerimeter()}");
            return sb.ToString();
        }
    }
}
