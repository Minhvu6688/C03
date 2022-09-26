using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03.ABSTRACT___INTERFACE
{
    public abstract class Animal
    {
        public  int Legs { get; private set; }

        protected Animal(int legs)
        {
            this.Legs = legs;
        }
        public virtual void Walk()
        {

        }
        public Animal()
        {
            Legs = 0;
        }
        public abstract void Eat();

    }
}
