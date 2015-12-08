using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningArv 
{
   sealed class  Bengal :Cat
    {
       public override void GetSound()
       {
           Console.WriteLine("Grrrr");
       }

       public override int GetMaximumSpeed()
       {
           return 88;
       }
    }
}
