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
            Juice juice = new Juice() { Id = 10009, Name = "Bravo", Mark = "ab", StockCount = 4, JuiceSort = "orange" };
            Juice juice1 = new Juice() { Id = 10010, Name = "Stockmos", Mark = "abio", StockCount = 7, JuiceSort = "apple" };

            Stock stock = new Stock();

            stock.AddItem(plate1);
            stock.AddItem(juice);
            stock.AddItem(juice1);
            int id = 0;
            int idPlate = 10000;
            int idJuice = 20000;
            string whatEcoMark = "";
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

                    int outAnswer;
                    bool answerResult = int.TryParse(Console.ReadLine(), out outAnswer);
                    if (answerResult)
                    {
                        switch (outAnswer)
                        {
                            case 1:
                                Console.WriteLine("What item do you want to add, juice or plate?");
                                string itemChoice = Console.ReadLine();

                                if (itemChoice.ToLower() == "juice")
                                {
                                    Console.WriteLine("Enter a name for the juice");
                                    string juiceName = Console.ReadLine();

                                    Console.WriteLine("How many items do you want in you stock");
                                    int stockJuice = int.Parse(Console.ReadLine());



                                    Console.WriteLine("Do you want apple or orangejuice");
                                    string fruitChoice = Console.ReadLine();

                                    Console.WriteLine("Do you want AB or ABIO?");
                                    whatEcoMark = Console.ReadLine();

                                    stock.AddItem(new Juice()
                                    {
                                        Name = juiceName,
                                        Id = idJuice,
                                        JuiceSort = fruitChoice,
                                        Mark = whatEcoMark,
                                        StockCount = stockJuice
                                    });

                                    idJuice++;
                                    Console.WriteLine("Your Id is " + idJuice);
                                }
                                if (itemChoice.ToLower() == "plate")
                                {
                                    Console.WriteLine("Enter a name for the plate");
                                    string plateName = Console.ReadLine();

                                    Console.WriteLine("How man items do you want in your stock?");
                                    int stockPlate = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Are they deep or flat");
                                    string plateSort = Console.ReadLine();

                                    stock.AddItem(new Plate()
                                    {
                                        Name = plateName,
                                        Id = idPlate,
                                        StockCount = stockPlate,
                                        Sort = plateSort
                                    });
                                    idPlate++;
                                    Console.WriteLine("Your Id is: " + idPlate);
                                }
                                else if (itemChoice != "juice" && itemChoice != "apple")
                                {
                                    throw new Exception("Answer should be juice or plate");
                                }
                                break;
                            case 2:
                                for (int i = 0; i < stock.stockItems.Length; i++)
                                {
                                    if (stock.stockItems[i] != null)
                                    {
                                        Console.WriteLine(stock.GetItem(i));
                                    }
                                }
                                Console.WriteLine("Vilken inventera");
                                int idNumber = int.Parse(Console.ReadLine());

                                for (int i = 0; i < stock.stockItems.Length; i++)
                                {
                                    if (stock.stockItems[i] != null && stock.stockItems[i].Id == idNumber)
                                    {
                                        id = idNumber;
                                    }
                                }

                                if (idNumber != id)
                                {
                                    throw new Exception("Id number does not exist");
                                }

                                Console.WriteLine("Hur många");
                                int newInventory = int.Parse(Console.ReadLine());

                                for (int i = 0; i < stock.stockItems.Length; i++)
                                {
                                    if (stock.stockItems[i] != null && stock.stockItems[i].Id == idNumber)
                                    {
                                        stock.stockItems[i].StockCount = newInventory;
                                        Console.WriteLine("Stock på id " + idNumber + " ändrad");
                                    }
                                }
                                break;
                            case 3:
                                ListItems(stock);
                                break;
                            case 4:
                                Console.WriteLine("Thank you, welcome back!!");
                                loop = false;
                                break;

                            default: throw new Exception("You can only choose between 1-4");
                        }
                    }
                    else
                    {

                        throw new Exception("You can only choose between 1-4");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }
         
            Console.ReadLine();
        }

        private static void ListItems(Stock stock)
        {
            Console.WriteLine("Ekologiska varor");
            for (int i = 0; i < stock.stockItems.Length; i++)
            {
                if (stock.stockItems[i] is EcoStockItem && stock.stockItems[i] != null)

                    Console.WriteLine(stock.GetItem(i));
            }
            Console.WriteLine("Ej ekologiska varor");
            for (int i = 0; i < stock.stockItems.Length; i++)
            {
                if (!(stock.stockItems[i] is EcoStockItem) && stock.stockItems[i] != null)
                {
                    Console.WriteLine(stock.GetItem(i));
                }
            }
        }
    }
}