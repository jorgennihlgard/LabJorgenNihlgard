using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Suv
    {


        public void Drive()
        {
            Console.WriteLine("VROOM VROOM");
        }

        public static explicit operator Car(Suv suv)
        {
            return new Car();
        }
    }
}
