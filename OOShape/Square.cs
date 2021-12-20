using System;
using System.Text;

namespace OOShape
{
    public class Square : Shape
    {

        public int SideLength { get; set; }


        public Square(int sideLength)
        {
           SideLength = sideLength;
            GetArea();
            GetPerimeter();
        }


        public override double GetArea()
        {
             return SideLength * SideLength;
           
        }

        public override double GetPerimeter()
        {
            return 4 * SideLength;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"This is square with side length {SideLength}, area {GetArea()} and perimeter length {GetPerimeter()}");
            return sb.ToString();
        }
    }
}
