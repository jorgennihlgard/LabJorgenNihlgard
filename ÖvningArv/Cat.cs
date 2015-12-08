using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningArv
{
         class Cat : Feline
    {
        public override void GetSound()
        {
            Console.WriteLine( "Mjau");
        }

        public override int GetMaximumSpeed()
        {
            return Speed;
        }
    }
}
