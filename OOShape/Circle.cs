using System;
using System.Text;

namespace OOShape
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        private double Area { get; set; }
        private double Perimeter { get; set; }
        

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            
            Area = 3.141592653589793238 * Radius * Radius;
            return Area;
        }

        public override double GetPerimeter()
        {
            Perimeter = 2 * 3.141592653589793238 * Radius;
            return Perimeter; 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"This is circle with radius {Radius}. The area is {GetArea()} and the perimeter is {GetPerimeter()}");
            return sb.ToString();
        }
    }
}
