using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {


           
            Plate plate1 = new Plate() { Id = 33, Name = "plate", StockCount = 7, Sort = "Flat" };
            Juice juice = new Juice() { Id = 99, Name = "Bravo", StockCount = 4, Sort = "Orange" };
            Juice juice1 = new Juice() { Id = 88, Name = "Stockmos", StockCount = 7, Sort = "Apple" };
            Plate[] plates = new Plate[50];
            Stock stock = new Stock();
            
            stock.AddItem(juice);
            stock.AddItem(juice1);

          


            // Console.WriteLine(juice);

            stock.GetItem(juice.Id);
            stock.GetItem(juice1.Id);
         
            Plate plate2 = new Plate();



            


            StockItem allChoices = new StockItem();
           
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("1-Skapa vara");
                Console.WriteLine("2-Inventera vara");
                Console.WriteLine("3-Lista varor");
                Console.WriteLine("4-Avsluta");

                int result = int.Parse(Console.ReadLine());

                if (result == 1) {
                    
                    Console.WriteLine("What item do you want to add, juice or plate?");
                    string itemChoice = Console.ReadLine();
                    if (itemChoice == "plate" || itemChoice == "juice")
                    {
                        allChoices.Name = itemChoice;
                    }
                    else
                    {
                        Console.WriteLine("There is only juice and plate available");
                        continue;
                    }
                    Console.WriteLine("What id number do you want your new item to have");
                    String id = Console.ReadLine();
                    int outValue;
                    bool idResult = int.TryParse(id, out outValue);

                    if (idResult)
                    {
                        allChoices.Id = outValue;
                    }
                    else
                    {
                        Console.WriteLine("You can only enter digits");
                    }







                }
                else if(result==2)
              
                {
                    Console.WriteLine("Vilken sort ska inventeras");
                    string obj = Console.ReadLine();
                    Console.WriteLine("Hur mycket blir det nya saldot");
                    int saldo =int.Parse(Console.ReadLine());
                    Console.WriteLine("Inventera");
                    juice.StockCount = saldo;
                }


                else if (result == 3)
                {
                    //for (int i = 0; i < .Length; i++)

                    //{

                    //    StockItem itm = allItems[i];

                    //    if (itm is EcoStockItem)
                    //    {

                    //    }
                    //}
                }
                else if (result == 4)
                {
                    Console.WriteLine("Avsluta");
                    break;
                }
            }
            Console.WriteLine("Thank you");

            Console.ReadLine();
        }
    }
}