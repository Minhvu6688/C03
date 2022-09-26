using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03.ABSTRACT_CLASS
{
    public class Rectangle : Shape
    {
        private int length;

        private int width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public Rectangle()
        {

        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public override double GetArea()
        {
            return this.length * this.width;
        }
        public override string ToString()
        {
            return "color: " + base.Color + ", Area: " + GetArea();
        }
    }
}
