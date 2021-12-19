using System;
using System.Text;

namespace OOShape
{
    public class Square : Shape
    {

        public int SideLength { get; set; }

        private double Area { get; set; }
        private double Perimeter { get; set; }

        public Square(int sideLength)
        {
           SideLength = sideLength;
            //Console.WriteLine("SideLength value:" + SideLength);
            GetArea();
            GetPerimeter();
        }


        public override double GetArea()
        {
             Area = SideLength * SideLength;
            //Console.WriteLine("Area value:" + Area);
            return Area;
           
        }

        public override double GetPerimeter()
        {
            Perimeter = 4 * SideLength;
           // Console.WriteLine("Perimeter value:" + Perimeter);
            return Perimeter;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"This is square with side length {SideLength}, area {GetArea()} and perimeter length {GetPerimeter()}");
            return sb.ToString();
        }
    }
}
