using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
   public class Car
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

      
        public override string ToString()
        {
            return $"Typ: {Type} Märke: {Brand} Antal växlar: {NrOfGears} Färg: {Color} ";
        }
    }
}
/*
Skapa en klass kallad Bil, som har fälten marke, antalVaxlar, farg och typ. Skapa properties för fälten. 
I set-delen av propertien som manipulerar fältet typ ska du se till att endast värdena "kupe" eller "kombi" kan användas, i andra fall ska fältet inte ändras.
Skapa instanser och prova att först sätta typ till "kombi", därefter till "suv", och läs ut vad typ har för värde.
*/
