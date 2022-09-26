using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03.ABSTRACT___INTERFACE
{
    public class Cat : Animal, IPet
    {
        public string Name { get; set; }

        public Cat()
        {

        }
        public Cat(string name)
        {
            this.Name = name;
        }
        public void Play()
        {
            Console.WriteLine("Cat is playing with you");
        }
        public override void Eat()
        {
            Console.WriteLine("Cat is eating");
        }
    }
}
