using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningArv
{
  abstract class Animal
    {
      public string Name { get; set; }
      public int Weight { get; set; }

      public abstract void GetSound(); //Kan inte deklarera en kropp på abstract
    }
}
