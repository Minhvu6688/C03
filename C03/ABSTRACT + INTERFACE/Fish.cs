using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03.ABSTRACT___INTERFACE
{
    public class Fish : Animal, IPet
    {
        public String Name { get; set; }

        public Fish()
        {

        }
        public void Play()
        {
            Console.WriteLine("Fish is playing");

        }
        public override void Eat()
        {
            Console.WriteLine("Fish is eating fish food");
        }
        public override void Walk()
        {
            Console.WriteLine("Fish is not leg");
        }

    }
}
