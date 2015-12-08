using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningArv
{
    sealed class IndianElephant : Elephant
    {
        public override void GetSound()
        {
            Console.WriteLine("Ptruuuuu");
        }
    }
    
}
