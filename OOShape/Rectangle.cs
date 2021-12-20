using System;
using System.Text;

namespace OOShape
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
     
        
        public Rectangle(int width, int height) : this(width)
        {
            Height = height;
        }

        public Rectangle(int equalSides)
        {
            Width = equalSides;
            Height = equalSides;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"This is rectangle with height {Height} and width {Width}. Area is {GetArea()} and perimeter is {GetPerimeter()}");
            return sb.ToString();
        }
    }
}
