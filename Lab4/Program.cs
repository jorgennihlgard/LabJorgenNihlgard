using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift1();


            Uppgift2Till5();

             //Uppgift6Cykel();

           //Uppgift6Bus();

            Console.ReadLine();

        }

        private static void Uppgift6Bus()
        {
            Bus bus = new Bus(numberOfSeats:30,seatsAvailable:30, type:"citybus",busRoute:240,doorsOpen: false,stopButtonPressed:false);
            Console.WriteLine("Folk vill hoppas på");
            bus.DoorsPassengerIn();
            Console.WriteLine(bus);
            bus.StopButton();
            Console.WriteLine(bus);
            Console.WriteLine("Folk vill hoppa på");
            bus.DoorsPassengerIn();
            Console.WriteLine(bus);
            bus.StopButton();
            Console.WriteLine(bus);
        }

        private static void Uppgift6Cykel()
        {
            Bicycle cykel = new Bicycle(numberOfGears:3, type: "herrcykel", brand: "kronan");
            Bicycle cykel2 = new Bicycle(numberOfGears: 5, type: "damcykel");
            Bicycle cykel3 = new Bicycle();
            Console.WriteLine(cykel);
            Console.WriteLine(cykel2);
            Console.WriteLine(cykel3);
            cykel.ChangeGearUp();
            cykel.Bell();
    

           


            Console.WriteLine(cykel);

            Console.WriteLine("Antal instanser: {0}", Bicycle.InstanceCount);
            Console.WriteLine("Antal damcyklar: {0} och antalherrcyklar: {1}", Bicycle.LadiesBicykle, Bicycle.MensBicycle);







        }
        private static void Uppgift2Till5()
        {
            Radio radio = new Radio(volume: 7, frequency: 94.5, radioOn: true);
            Console.WriteLine(radio);

            Radio radio2 = new Radio();
            Console.WriteLine(radio2);

            Radio radio3 = new Radio() { Volume = 3, Frequency = 104.3, RadioOn = true };
            Console.WriteLine(radio3);

            Radio radio4 = new Radio() { Volume = 9, Frequency = 103.2 };
            Console.WriteLine(radio4);

            Console.WriteLine("Antal instanser: {0}", Radio.InstanceCount);
        }

        private static void Uppgift1()
        {
            Car bil = new Car(type: "kupe", brand: "Ford", nrOfGears: 5, color: "Grön");
            Console.WriteLine(bil);
        }
    }
}




