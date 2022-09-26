using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03.ABSTRACT___INTERFACE
{
    public class Spider : Animal
    {
        public Spider()
        {
            
        }
        public override void Eat()
        {
            Console.WriteLine("Spider is eating");
        }
    }
}
