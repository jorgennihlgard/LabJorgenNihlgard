using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Radio
    {
        private int volume;
        private bool radioOn;
        private double frequency;
        private static int instanceCount;

        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value <= 10)
                    volume = value;
                else
                    throw new Exception("Volyminställning ska vara 0-10");
            }
        }
        public bool RadioOn
        {
            get { return radioOn; }
            set
            {
                radioOn = value;
            }
        }
        public double Frequency
        {
            get { return frequency; }
            set
            {
                if (value > 50 && value < 200)
                    frequency = value;
                else
                    throw new Exception("Frekvens ska vara mellan 50-200");
            }
        }
        static public int InstanceCount
        {
            get
            {
                return instanceCount;
            }
        }
        static Radio()
        {
            instanceCount = 0;
        }
        public Radio()
        {
            Volume = 5;
            Frequency = 104.5;
            RadioOn = false;
            instanceCount++;
        }

        public Radio(int volume, double frequency):this()
        {
            Volume = volume;
            Frequency = frequency;
        }
        public Radio(int volume, double frequency, bool radioOn = false) : this(volume, frequency)
        {
            //Volume = volume;
            //Frequency = frequency;
            RadioOn = radioOn;
        }

      
        public override string ToString() {

            string status = "";
            if (RadioOn)
                status = "på";
            else
            {
                status = "av";
            }
               return $"Volym är:{Volume} Frekvensen är: {Frequency} Radion är {status}";
        }
    }
}

/*

  

    Uppgift 4

Utgå från Radio-klassen, och utöka denna så att den håller reda på hur många instanser som skapats.
Skapa först ett statiskt fält kallas instanceCount, som du exponerar mha en read-only property.
Initiera fältet till 0 i en statisk konstruktor, och räkna upp detta fält i default-konstruktorn.
Eftersom denna konstruktor anropas från den andra konstruktorn så kommer alltid fältet räknas upp oavsett 
vilken constructor som anropas.
      
    Uppgift 3

Utgå från klassen i föregående uppgift och utöka den med två konstruktors som initierar Radion.
Den ena konstruktorn ska vara default-konstruktorn, och den andra ska sätta volym och frekvens.
I båda fallen ska on/off sättas till off. Sätt vettiga förval på alla fält i 
default-konstruktorn som du sedan anropar från den andra konstruktorn. 
Konstruktorn som tar argument ska använda dina properties för att sätta fälten, 
dvs manipulera inte fälten direkt från konstruktorn. Detta gör att valideringen endast 
behöver göras på ett ställe. Hela detta upplägg gör att din klass alltid kommer innehålla 
giltig information.

Uppgift 2

    I denna uppgift får du själv funder lite på hur klassen ska implementeras.
Skapa en klass i en ny fil som du lägger till projektet. Kalla klassen Radio.
Denna klass ska modellera en riktig radio, där kontroller finns för volym, av/på, 
samt frekvensinställning. Fundera på vilka datatyper som ska användas för respektive fält.
Validera indata till både volym och frekvens för att se till att dessa håller sig inom 
rimliga gränser.


  
*/
