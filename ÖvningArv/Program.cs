using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4;

namespace ÖvningArv
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //object o = true;
            //string a = "3";
            //int b = 4;
            //double c = 6.5;
            //char d = 'r';
            //bool e = false;
            // c = b;        //int till double blir 4,  mindre i en större
            //b = (int)c;       // double till int blir 6,  explicit större i mindre och från decimaltal
            //d = char.Parse(a);  // string till char, ett tecken
            //d = (char)b;  // int till char  blir tecken ASCII
            //b = d;   // char till int   ASCII värdet av r
            //c = d;     // char till double samma som ovan
            //c =double.Parse(a);   //string till double
            //b = int.Parse(a);      // string till int
            //d = char.Parse(a);     // string till char
            //e = bool.Parse(a);       // string till bool Måste vara true eller false
            // o = a;  // Till object funkar på alla
            // o = b;
            //o = c;
            // o = d;
            // o = e;
            //a = (string)o; // object till string om obbject är en string
            //b = (int)o;  //object till int om object är en int
            //c = (double)o;  // object till double om object är double
            //d = (char)o;  //object till char om object är ett char tecken
            //e = (bool)o;     // object till bool om object är true eller false


         //   Console.WriteLine(o);   
           
            
            
            
            
             Point3D point3d = new Point3D(x: 4, y:8, z:12);

            Console.WriteLine(point3d.Z +" "+ point3d.Y+" "+point3d.X);


            C subklass = new C();
            B bklass = new B();



            SUV suv = new SUV();
            suv.Drive();
            Car car = (Car)suv;
            car.Drive();
          
            Car bil2 = new Car();
            SUV suv1 = (SUV)bil2;
            suv1.Drive();

            //Uppgift7

            //Animal animal = new Animal(); //Kan inte göra en instans av en abstract klass
            //animal.GetSound();

            //uppgift9
            Cat cat = new Cat() {Speed = 23,Weight = 10, Name = "Svante"};
            cat.GetSound();
            Console.WriteLine(cat.Speed);
          //uppgift10
          Bengal bengal = new Bengal();
            Console.WriteLine(bengal.GetMaximumSpeed());
          //uppgift 11
             Cat cat1 = new Cat();
            Bengal bengal1 = new Bengal();
            Cat cat2 = bengal1;
           
            Console.WriteLine(cat1.GetMaximumSpeed());
            cat2.GetSound();

            Object obj = new Object();

           Bengal bengal22= new Bengal();

            Object ob = bengal22 as object;
            Bengal ben = obj as Bengal;
            if (ben == null)
            {
                Console.WriteLine(  "ggfgfg");
            }

            Object o = bengal22;



           

            //uppgift12
            IndianElephant iniIndianElephant = new IndianElephant() {Color = "brown", Legs = 4, Speed=22};
            AfricanElephant africanElephant = new AfricanElephant() {Color= "Grey", Legs=4, Speed = 33};
         
            iniIndianElephant.GetSound();
            africanElephant.GetSound();
           




            //Testa operatorerna is och as genom att skapa en instans av Bengal och en av Cat. Är Bengal en Cat? Är Cat en Bengal? Går det bra att typomvandla en Bengal till Object med as? Tvärtom ?
            Console.ReadLine();
        }
    }
}

/*
Uppgift 1

I Main: Skapa en variabel av typen objekt, en string, en int, en double,
en char och en bool. Testa att typomvandla mellan dessa. 
Notera vad kompilatorn säger i de olika fallen, och fundera på varför den säger så. 
Det finns omvandlingar som går bra att göra utan att säga till (dvs implicita),
omvandlingar där man måste säga till att man verkligen vill utföra den (dvs explicita)
och så finns det omvanlingar som inte går att göra mha en typkonvertering.
Ett exempel på sistnämnda är omvandling av en string till en double. För att
utföra det måste strängen "parsas" till en double, vilket görs mha 
metoden double.Parse(string).
*/
