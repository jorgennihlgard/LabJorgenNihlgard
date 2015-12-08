using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningArv
{
   abstract class Elephant
   {
       public int Legs { get; set; } 
       public int Speed { get; set; }
       public string Color { get; set; }


       public abstract void GetSound();
   }
}
