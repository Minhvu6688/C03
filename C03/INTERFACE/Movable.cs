using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03.INTERFACE
{
    internal class Movable : IMovable
    {
        private int x;
        private int y;

        public Movable(int x, int y)
        {
            this.x = x; this.y = y;
        }
        public Movable()
        {
            this.x = 0; this.y = 0;
        }
        public override string ToString()
        {
            return "(" + this.x + "," + this.y + ")"; 
        }

        public void MoveUp()
        {
            y++;
        }

        public void MoveDown()
        {
            y--;
        }

        public void MoveLeft()
        {

            x--;
        }

        public void MoveRight()
        {

            x++;
        }


    }
}
