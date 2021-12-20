using System;
using System.Text;

namespace OOShape
{
    public class Circle : Shape
    {
        public int Radius { get; set; }


        public Circle(int radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            
            return 3.141592653589793238 * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * 3.141592653589793238 * Radius;
          
        }

        public override void SayHello()
        {
            Console.Write("Welcome to Circle!!!");   
        }

        public override void ScreamHello()
        {
            Console.WriteLine($"Circle's area and perimeter calculated with radius value {Radius}");
        }
        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"This is circle with radius {Radius}. The area is {GetArea()} and the perimeter is {GetPerimeter()}");
            return sb.ToString();
        }
    }
}
