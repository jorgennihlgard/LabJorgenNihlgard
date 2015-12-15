using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    

    class Suv
    {
        public int NrOfGears { get; set; }
       public string Color { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }

       
        public void Drive()
        {
            Console.WriteLine("VROOM VROOM");
        }

      

        public override string ToString()
        {
            return ($"Brand:{Brand}");
        }
    }
}
