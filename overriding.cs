using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{


    class animal
    {
        public animal()
        {
            Console.WriteLine("animal constructor");
        }
        public virtual void makesound()
        {
            Console.WriteLine("make sound");
        }
    }
    class dog:animal
    {
        public dog()
        {
            Console.WriteLine("dog constructor");
        }
        public override void makesound()
        {
            Console.WriteLine("bark");
        }

    }





    class Program
    {
        static void Main()
        {
            dog obj = new dog();
            obj.makesound();
        }
    }
}
