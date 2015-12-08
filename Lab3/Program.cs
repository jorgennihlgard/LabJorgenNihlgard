using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift1();
            //Uppgift2();
            //Uppgift3();
            //Uppgift4();
            Uppgift5();
        }

        private static void Uppgift5()
        {
            Computer computer = new Computer();
            computer.SetModell("laptop");
            Console.WriteLine(computer.GetModell());
            computer.SetProcessor("I7");
            computer.SetRam("8gb");
            Mouse mouse = new Mouse();
            mouse.setButtons(2);
            mouse.SetColor("Grey");
            computer.SetAccessories(mouse);
            Console.WriteLine($"Finns {computer.GetAccessories().GetButtons()} knappar på musen och färgen är {computer.GetAccessories().GetColor()}");
            Console.ReadLine();
        }

        private static void Uppgift4()
        {
            Point point = new Point();
            point.SetX(8);
            point.SetY(4);
            Circle circle = new Circle();
            circle.SetDiameter(5);
            circle.SetCenter(point);
            Console.WriteLine("X: " + circle.GetCenter().GetX() + " Y: " + circle.GetCenter().GetY());
        }

        private static void Uppgift3()
        {
            Point point = new Point();
            point.SetX(2);
            point.SetY(3);
            Console.WriteLine("X är: "+ point.GetX()+ " Y är: "+point.GetY());
            Point point2 = new Point();
            point.SetX(4);
            point.SetY(5);
            Console.WriteLine("X är: " + point.GetX() + " Y är: " + point.GetY());
        }

        private static void Uppgift2()
        {
            Circle circle = new Circle();
            circle.SetDiameter(5.5);
            Console.WriteLine("{0:f2}", circle.GetCircumference());
        }

        private static void Uppgift1()
        {
            Person person = new Person();
            person.SetName("Jörgen");
            Console.WriteLine(person.GetName());
            Person person2 = new Person();
            person2.SetName("Sven");
            Console.WriteLine(person2.GetName());
        }
    }
}
