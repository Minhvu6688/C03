using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03.ABSTRACT_CLASS
{
    public abstract class Shape
    {
        private String _color;
        public Shape()
        {
            this._color = "green";
        }
        public String Color
        {
            get { return this._color; }
            set { this._color = value; }
        }

        public abstract double GetArea();

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
