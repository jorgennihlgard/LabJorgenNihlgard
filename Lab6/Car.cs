using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Car
    {
        private string type;
        private int numberOfGears;

        public string Type
        {
            get { return type; }
            set
            {
                var typeOfCar = value == "kupe" || value == "kombi";
                if (typeOfCar)
                {
                    type = value;
                }
                else
                {
                    throw new Exception("Typen måste vara kupe eller kombi");
                }
            }

        }

        public int NrOfGears
        {
            get { return numberOfGears; }
            set
            {
                if (value >= 1 && value <= 5)
                    numberOfGears = value;
                else
                {
                    throw new Exception("Växlar ska vara mellan 1-5");
                }
            }
        }
        public string Brand { get; set; }
        public string Color { get; set; }
        public Car(string type = "kupe", string brand = "Ford", int nrOfGears = 5, string color = "Grön")
        {
            Type = type;
            Brand = brand;
            NrOfGears = nrOfGears;
            Color = color;

        }

        public virtual void Drive()
        {
            Console.WriteLine("brum brum");
        }

        public static explicit  operator Suv(Car car)
        {
            return new Suv();
       }
        public override string ToString()
        {
            return $"Typ: {Type} Märke: {Brand} Antal växlar: {NrOfGears} Färg: {Color} ";
        }
    }
}
