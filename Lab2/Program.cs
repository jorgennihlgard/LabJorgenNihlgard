using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double dowJones = 0.046;
            double nasdaq = 0.041;
            double stockholm = -0.024;
            double milano = -0.067;
            double paris = -0.055;

            Console.WriteLine(
                "Dow Jones sjönk med {0:p} och Nasdaq med {1:p}, Stockholm {2:p},\n Milano {3:p}" +
                " , Paris {4:p}.\n", dowJones, nasdaq, stockholm, milano, paris);

            dowJones = 0.012;
            nasdaq = 0.011;
            stockholm = 0.014;
            milano = -0.015;
            paris = -0.017;

            Console.WriteLine(
               "Dow Jones sjönk med {0:p} och Nasdaq med {1:p}, Stockholm {2:p} procent,\n Milano {3:p}" +
               " , Paris {4:p}.\n", dowJones, nasdaq, stockholm, milano, paris);


            //PI är en konstant och kan inte ändras
            const double PI = 3.141592654;
            double round = 3.14;
            double rough = 3;
            Console.WriteLine("Talet π är cirka {0} men kan avrundas till {1} och kan lite grovt\n skrivas som {2}.\n", PI, round, rough);



            string name = "Jonas";
            Console.WriteLine("Han heter {0} och bor i Helsingborg på Stattena vid Hemköp.\n", name);

            name = "Kenneth";
            Console.WriteLine("Han heter {0} och bor i Helsingborg på Stattena vid Hemköp.", name);



        }
    }
}