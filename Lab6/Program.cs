using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift1();


            Uppgift3();

            //Uppgift4();
           // Uppgift5();

            Console.ReadLine();




        }
        private static void Uppgift1()
        {
            float f = 1234.3f;
            long l = 2555666L;
            char c = 'a';
            string s = "hello";
            ulong ul = 34323434UL;
        }
        private static void Uppgift3()
        {
            PointStruct pointStruct = new PointStruct(7, 8);
            Console.WriteLine($"Point X: {pointStruct.X} Y: {pointStruct.Y}");

            Point3DStruct point3DStruct = (Point3DStruct)pointStruct;
            Console.WriteLine($"Point till Point3D X: {point3DStruct.X} Y: {point3DStruct.Y} Z: {point3DStruct.Z}");


            PointStruct pointStruct1 = (PointStruct)point3DStruct;
            Console.WriteLine($"Point 3D till Point X: {pointStruct1.X} Y: {pointStruct1.Y}");



        }
        private static void Uppgift4()
        {
            MyDoubleType mdt1 = new MyDoubleType(15);
            MyDoubleType gg = mdt1 - 15;


            MyDoubleType mdt2 = mdt1 + 5;
            MyDoubleType mdt3 = mdt1 - 10;
            MyDoubleType mdt4 = new MyDoubleType(9);


            Console.WriteLine("{0} {1} {2} {3} {4}", mdt1, mdt2, mdt3, mdt4 == mdt1, mdt2 > mdt3);
        }
        private static void Uppgift5()
        {
            Car car = new Car();
            Console.WriteLine(car);

            Suv suv = (Suv)car;
            Console.WriteLine($"Color: {suv.Color} Gears:{suv.NrOfGears}Type{suv.Type}Brand: {suv.Brand}");
        }

      

       

       
    }
}
