using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Computer
    {
        private string processor;
        private string ram;
        private string modell;
        private Mouse accessories;


        public void SetProcessor(string processor)
        {
            this.processor = processor;
        }

        public string GetProcessor()
        {
            return processor;
        }

        public void SetRam(string ram)
        {
            this.ram = ram;
        }

        public string GetRam()
        {
            return ram;
        }

        public void SetModell(string modell)
        {
            if (modell != "desktop" && modell != "laptop")
            {
                Console.WriteLine("Modell ska vara desktop eller laptop");
            }
            this.modell = modell;
        }

        public string GetModell()
        {
            return modell;
        }

        public void SetAccessories(Mouse a)
        {
            accessories = a;
        }
        public Mouse GetAccessories()
        {
            return accessories;
        }

    }
}
