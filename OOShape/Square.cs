using System;
namespace OOShape
{
    public class Square : Shape
    {

        public int SideLength { get; set; }
       
        public Square(int sideLength)
        {
           SideLength = sideLength;
        }
    }
}
