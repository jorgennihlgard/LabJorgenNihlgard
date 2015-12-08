using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningArv
{
   sealed class AfricanElephant : Elephant
    {
       public override void GetSound()
       {
           Console.WriteLine("Frwwooooiii..");
       }
    }
}
