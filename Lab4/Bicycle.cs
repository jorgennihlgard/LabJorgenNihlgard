using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bicycle
    {
        private string brand;
        private int noOfGears;
        private string type;
        private int yourGear;
        private static int instanceCount;
        private static int mensBicykle;
        private static int ladiesBicykle;
        

        public static int InstanceCount
        {
            get { return instanceCount; }
        }

        public static int MensBicycle
        {
            get { return mensBicykle; }
        }
        public static int LadiesBicykle
        {
            get { return ladiesBicykle; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int NumberOfGears
        {
            get { return noOfGears; }
            set
            {
                if (value > 0 && value < 6)
                {
                    noOfGears = value;
                }
                else
                {
                    throw new Exception("Finns 1- 5 växlar på denna cykel");
                }
            }
        }
        public string Type
        {
            get { return type; }
            set
            {
                if (value == "damcykel" || value == "herrcykel")
                {
                    type = value;
                }

                else
                {
                    throw new Exception("Typen ska vara dam eller herrcykel");
                }
            }
        }

        public int YourGear
        {
            get
            {
                return yourGear;
            }
            set
            {
                if(value>0&&value<=noOfGears)
                yourGear = value;
                else
                {
                    throw new Exception("Blivit något fel, denna växel ska du inte kunna ha, du har" + noOfGears + "växlar");
                }
            }
        }
        public Bicycle(int numberOfGears = 5, string type = "herrcykel", string brand = "Monark",int yourGear = 1)
        {
            NumberOfGears = numberOfGears;
            Type = type;
            Brand = brand;
            YourGear = yourGear;
            instanceCount++;
            if (type == "herrcykel")
            {
                mensBicykle++;
            }
            else if (type == "damcykel")
            {
                ladiesBicykle++;
            }
        }

        static Bicycle()
        {
            instanceCount = 0;
            mensBicykle = 0;
            ladiesBicykle = 0;
        }
        public int ChangeGearUp()
        {
            var gearUnderMax = noOfGears > YourGear;
            if (gearUnderMax)
            {
                return YourGear++;
            }
            else
            {
                throw new Exception("Du har inte flera växlar");
            }
        }

 
        public int ChangeGearDown()
        {
            var gearAboveMin = YourGear > 1;
            if (gearAboveMin)
               return YourGear--;
            else
                throw new Exception("Du ligger i ettans växel och kan inte växla ner mer.");
        }

        public void Bell()
        {
            Console.WriteLine("Ring i klockan, hur många gånger vill du ringa");
            string input = Console.ReadLine();
            int count;
            var countIsNr = int.TryParse(input, out count);
            if (countIsNr)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.Beep();
                }
            }
            else
            {
                throw new Exception($"{input} är ingen siffra, måste vara en siffra");
            }
            Console.WriteLine("Pliing pliiing");
        }
        public override string ToString() => $"Antal växlar: {NumberOfGears} Typen är:{Type} Märket är: {Brand} Du ligger i växel {YourGear}";

    }
}
/*
  Uppgift 6

Leta upp objekt i din vardag och modellera dessa som klasser. Ta med så mycket olika 
medlemstyper som möjligt, förutsatt att det är motivera såklart!

T.ex. en Cykel-klass har properties Marke, AntalVaxlar, Typ, olika constructors för att 
initiera olika delar av cykeln i samma anrop, metoder för att byta växel och plinga i 
klockan(?). Kanske kan man även tänka sig att klassen håller reda på hur många cyklar av
varje Typ som skapats? Indata till AntalVaxlar och Typ måste såklart även valideras. 
Fundera och bygg ut själv. Gå sedan vidare och hitta på egna klasser.
*/
