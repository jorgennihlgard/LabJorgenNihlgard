using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Plate plate1 = new Plate() { Id = 10008, Name = "plate", StockCount = 88, Sort = "flat" };
            Juice juice = new Juice() { Id = 10009, Name = "Bravo", StockCount = 4, JuiceSort = "orange" };
            Juice juice1 = new Juice() { Id = 10010, Name = "Stockmos", StockCount = 7, JuiceSort = "apple" };
       
            Stock stock = new Stock();

            stock.AddItem(plate1);
            stock.AddItem(juice);
            stock.AddItem(juice1);

            int idPlate = 10000;
            int idJuice = 20000;

            //string[] qu = {"Vilket namn", "Hur mycket i lager", "Märkning"};

            //for (int i = 0; i < qu.Length; i++)
            //{
            //    Console.WriteLine(qu[i]);
            //   string ee= Console.ReadLine();

            //    for (int j = 0; j <= i; j++)
            //    {
            //        string ju = ee;
            //        stock.AddItem(new Juice(ju));
                    
            //    }
            //}
        


            bool loop = true;
            while (loop)
            {
                try
                {
                    Console.WriteLine("1-Skapa vara");
                    Console.WriteLine("2-Inventera vara");
                    Console.WriteLine("3-Lista varor");
                    Console.WriteLine("4-Avsluta");

                    string answer = Console.ReadLine();
                    int outAnswer;
                    bool answerResult = int.TryParse(answer, out outAnswer);
                    if (answerResult)
                    {
                        switch (outAnswer)
                        {
                            case 1:
                                Console.WriteLine("What item do you want to add, juice or plate?");
                                string choice = Console.ReadLine();

                                if (choice == "juice")
                                {
                                    Console.WriteLine("Enter a name for the juice");
                                    string juiceName = Console.ReadLine();

                                        Console.WriteLine("How many items do you want in you stock");
                                    int stockJuice = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Do you want apple or orangejuice");
                                    string fruitChoice = Console.ReadLine();

                                    Console.WriteLine("Do you want your juice to be ecological, Y or N?");
                                    string ecoOrNot = Console.ReadLine();
                                    if (ecoOrNot.ToLower() == "y")
                                    {
                                        Console.WriteLine("Do you want AB or ABIO?");
                                        string whatEcoMark = Console.ReadLine();

                                        Console.WriteLine("Your Id is " + idJuice);
                                        idJuice++;
                                    }
                                    stock.AddItem(new Juice()
                                    {
                                        Name = juiceName,
                                        Id = idJuice,
                                        JuiceSort = fruitChoice,
                                        Mark = ecoOrNot,
                                        StockCount = stockJuice
                                    });
                                }
                                if (choice == "plate")
                                {
                                    Console.WriteLine("Enter a name for the plate");
                                    string plateName = Console.ReadLine();

                                    Console.WriteLine("How man items do you want in your stock?");
                                    int stockPlate = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Are they deep or flat");
                                    string plateSort = Console.ReadLine();

                                  
                                    idPlate++;
                                    Console.WriteLine("Your Id is: " +idPlate );

                                    stock.AddItem(new Plate()
                                    {
                                        Name = plateName,
                                        Id = idPlate,
                                        StockCount = stockPlate,
                                        Sort = plateSort

                                    });
                                }
                    break;
                    case 2:
                                for (int i = 0; i < stock.stockItems.Length; i++)
                                {
                                    if (stock[i] != null)
                                        Console.WriteLine(stock[i]);
                                }
                                Console.WriteLine("Vilken inventera");
                                int idNumber = int.Parse(Console.ReadLine());

                                Console.WriteLine("Hur många");
                                int newInventory = int.Parse(Console.ReadLine());
                                stock.GetItem(idNumber);
                                for (int i = 0; i < stock.stockItems.Length; i++)
                                {

                                     stock[i].StockCount = newInventory;
                                }
                               
                               
                             
                                
                                break;
                            case 3:
                                
                                Console.WriteLine("Ekologiska varor");
                                for (int i = 0; i < stock.stockItems.Length; i++)
                                {
                                    if (stock.stockItems[i] is EcoStockItem && stock.stockItems[i] != null)

                                        Console.WriteLine(stock[i]);
                                }
                                Console.WriteLine("Ej ekologiska värden");
                                for (int i = 0; i < stock.stockItems.Length; i++)
                                    {
                                        if (!(stock.stockItems[i] is EcoStockItem) && stock.stockItems[i]!= null)
                                        {
                                            Console.WriteLine(stock[i]);
                                        }
                                    }
                                break;
                     case 4:
                                Console.WriteLine("Abort");
                                loop = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You can only choose between 1-4");
                        throw new Exception("You can only choose between 1-4");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
            }
            Console.WriteLine("Thank you");
            Console.ReadLine();
        }
    }
}