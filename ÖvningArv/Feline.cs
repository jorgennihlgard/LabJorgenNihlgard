using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningArv
{
   abstract class Feline :Animal
   {
       public int Speed { get; set; }   
       public abstract int GetMaximumSpeed();
        
   }
}
