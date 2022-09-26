using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03.ABSTRACT_CLASS
{
    public class Triangle : Shape
    {
        private int _base;

        private int _height;

        public Triangle()
        {
            _base = 0;
        }
        public Triangle(int @base, int height)
        {
            _base = @base;
            _height = height;
        }

        public int Base
        {
            get { return _base; }
            set { _base = value; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public override double GetArea()
        {
            return this.Base * this.Height * 1/2;
        }
        public override string ToString()
        {
            return "color: " + base.Color + ", Area: " + GetArea();
        }
    }
}
