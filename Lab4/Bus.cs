using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Bus
    {
        private byte numberOfSeats;
        private bool doorsOpen;
        private byte seatsAvailable;
        private bool stopButtonPressed;
        private string type;
        private int busRoute;
        private byte totPassengers;

        public byte NumberOfSeats
        {
            get { return numberOfSeats; }
            set
            {
                var SeatsOnBus = value >= 10 && value <= 50;
                if (SeatsOnBus)
                    numberOfSeats = value;
                else
                {
                    throw new Exception("Bussarna har mellan 10 och 50 platser.");
                }
            }

        }
        public bool DoorsOpen
        {
            get { return doorsOpen; }
            set { doorsOpen = value; }
        }
        public byte SeatsAvailable
        {
            get { return seatsAvailable; }
            set
            {
                var seatsAreAvailable = value > 0 && value <= numberOfSeats;
                if (seatsAreAvailable)
                    seatsAvailable = value;
                else
                {
                    throw new Exception("Du försöker släppa in mer folk än det finns plats på bussen, eller släppa ut fler personer än vad som finns.");
                }
            }
        }
            public bool StopButtonPressed
        {
            get { return stopButtonPressed; }
            set { stopButtonPressed = value; }
        }
        public string Type
        {
            get { return type; }
            set
            {
                if (value == "citybus" || value == "countrybus")
                {
                    type = value;
                }
                else
                {
                    throw new Exception("Typen måste vara citybus eller countrybus.");
                }
            }
        }
        public int BusRoute
        {
            get { return busRoute; }
            set
            {
                var valueBusRoute = value >= 100 && value <= 300;
                if (valueBusRoute)
                    busRoute = value;
                else
                {
                    throw new Exception("Inte ett giltigt linjenummer.");
                }
            }
        }
        public byte TotPassengers
        {
            get { return totPassengers; }
            set
            {
                var passengersOnBus = value >= 0 && value < numberOfSeats;
                if (passengersOnBus)
                totPassengers = value;
                else
                {
                    throw new Exception("Du försöker släppa in mer folk än det finns plats på bussen, eller släppa ut fler personer än vad som finns.");
                }
            }
        }


        public Bus()
        {
            NumberOfSeats = 20;
            DoorsOpen = false;
            SeatsAvailable = 20;
            StopButtonPressed = false;
            Type = "Citybus";
            BusRoute = 240;
        }
        public Bus(byte numberOfSeats, byte seatsAvailable, string type, int busRoute, bool doorsOpen = false, bool stopButtonPressed = false)
        {
            NumberOfSeats = numberOfSeats;
            SeatsAvailable = seatsAvailable;
            Type = type;
            BusRoute = busRoute;
            DoorsOpen = doorsOpen;
            StopButtonPressed = stopButtonPressed;
        }

        private int NewPassengers()
        {
            Console.WriteLine("Hur många släpps in?");
            string answerNewPassengers = Console.ReadLine();
            byte newPassenger;
            bool nrNewPassengers = byte.TryParse(answerNewPassengers, out newPassenger);
            if (nrNewPassengers)
                TotPassengers += newPassenger;
            SeatsAfterPassengerIn(newPassenger);
            doorsOpen = false;
            return TotPassengers;
        }
        public int SeatsAfterPassengerIn(byte newPassenger)
        {
            SeatsAvailable -= newPassenger;
            return SeatsAvailable;
        }
        public void DoorsPassengerIn()
        {
            Console.WriteLine("Dörrar är stängda, vill ni öppna dem");
            string answerDoors = Console.ReadLine();
            if (answerDoors == "ja")
            {
                doorsOpen = true;

                NewPassengers();

            }
            else if (answerDoors == "nej")
            {
                Console.WriteLine("Bussen kör vidare");
            }
            else
            {
                throw new Exception("Ogiltigt svar, svara ja eller nej");
            }
        }

    
        public int SeatsAfterPassengerOut(byte passengerOff)
        {
            SeatsAvailable += passengerOff;
            return SeatsAvailable;
        }
        private void PassengersLeaveBus()
        {
                Console.WriteLine("Hur många släpper du ut");
                string answerPassengerOut = Console.ReadLine();
                byte NrPassengerOut;
                bool answerPass = byte.TryParse(answerPassengerOut, out NrPassengerOut);
                TotPassengers -= NrPassengerOut;
                SeatsAfterPassengerOut(NrPassengerOut);
                stopButtonPressed = false;
                doorsOpen = false;
        }
        private void DoorsPassengerOut()
        {
            Console.WriteLine("Vill du öppna dörren för att släppa ut folk");
            string answerButton = Console.ReadLine();
            if (answerButton == "ja")
            {
                doorsOpen = true;
                PassengersLeaveBus();

            }
            else if (answerButton == "nej")
            {
                Console.WriteLine("Bussen kör vidare");
                stopButtonPressed = false;
            }
            else
            {

                throw new Exception("Ogiltigt svar");
            }

        }

        public void StopButton()
        {
            Console.WriteLine("Stoppknapp intryckt");
            StopButtonPressed = true;
            DoorsPassengerOut();

        }


        public override string ToString()
        {
            string statusDoors = "";
            if (doorsOpen)
            {
                statusDoors = "öppna";
            }
            else
            {
                statusDoors = "stängda";
            }
            string statusStopButton = "";
            if (stopButtonPressed)
                statusStopButton = "nedtryckt";
            else
            {
                statusStopButton = "ej nedtryckt";
            }


            return $"Bussen har {NumberOfSeats} platser och är av typ {Type}. \n" +
                $"Den har {TotPassengers} passagerare och {SeatsAvailable} säten lediga \n" +
                $"Dörrarna är {statusDoors} och stoppknappen är {statusStopButton}";
        }

    }
}


