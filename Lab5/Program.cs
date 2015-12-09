using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            Juice juice = new Juice() { Id = 99, Name = "Bravo", StockCount = 4, JuiceSort = "Orange" };
            Juice juice1 = new Juice() { Id = 88, Name = "Stockmos", StockCount = 7, JuiceSort = "Apple" };
            Plate[] plates = new Plate[50];
            Stock stock = new Stock();
            Juice juiceChoice = new Juice();
            Plate plateChoice = new Plate();
            StockItem allChoices = new StockItem();
            stock.AddItem(juice);
            stock.AddItem(juice1);

            


            stock.AddItem(juiceChoice);

            bool loop = true;
            while (loop)
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
                            Console.WriteLine("What item do you want to add, press 1 for Juice or 2 for Plate?");
                            Console.WriteLine("1-Juice");
                            Console.WriteLine("2-Plate");

                            string choice = Console.ReadLine();
                            int outChoice;
                            bool choiceResult = int.TryParse(choice, out outChoice);

                            if (outChoice == 1)
                            {
                                juiceChoice.Name = "Juice";
                                Console.WriteLine("What id number do you want your new item to have");
                                String idJuice = Console.ReadLine();
                                int outValue;
                                bool idJuiceResult = int.TryParse(idJuice, out outValue);
                                if (idJuiceResult)
                                {
                                    juiceChoice.Id = outValue;
                                }
                                else
                                {
                                    Console.WriteLine("You can only enter digits");
                                    throw new Exception("You can only enter digits");
                                }
                                Console.WriteLine("How many items do you want in you stock");
                                string stockJuice = Console.ReadLine();
                                int stockOutValue;
                                bool stockJuiceResult = int.TryParse(stockJuice, out stockOutValue);
                                if (stockJuiceResult)
                                {
                                    juiceChoice.StockCount = stockOutValue;
                                }
                                else
                                {
                                    Console.WriteLine("You can only enter digits");
                                    throw new Exception("You can only enter digits");
                                }
                                Console.WriteLine("Do you want apple or orangejuice");
                                string fruitChoice = Console.ReadLine();
                                if(fruitChoice=="orange")

                                Console.WriteLine("Do you want your juice to be ecological, Y or N?");
                                string ecoOrNot = Console.ReadLine();
                                if (ecoOrNot.ToLower()=="y")
                                {
                                    Console.WriteLine("Do you want AB or ABIO?");
                                    string whatEcoMark = Console.ReadLine();
                                    if (whatEcoMark=="ABIO")
                                    {
                                        juiceChoice.Mark = whatEcoMark;
                                    }
                                    else if (whatEcoMark.ToLower()=="AB")
                                    {
                                        juiceChoice.Mark = whatEcoMark;
                                    }
                                }
                                else if (ecoOrNot.ToLower()=="n")
                                {
                                    stock.AddItem(juiceChoice);
                                }
                                else
                                {
                                    Console.WriteLine("You can type y or no");
                                    throw new Exception("You can type y or no");
                                }
                                //string ecoJuice = Console.ReadLine();
                                //int ecoValue;
                                //bool ecoJuiceResult = int.TryParse(ecoJuice, out ecoValue);
                                //if (ecoJuiceResult)
                                //{
                                //    juiceChoice.Mark = 
                                //}
                            }
                            if (outChoice == 2)
                            {
                                plateChoice.Name = "Plate";
                                Console.WriteLine("What id number do you want your new item to have");
                                String idPlate = Console.ReadLine();
                                int outValue;
                                bool idPlateResult = int.TryParse(idPlate, out outValue);
                                if (idPlateResult)
                                {
                                    plateChoice.Id = outValue;
                                }
                                else
                                {
                                    Console.WriteLine("You can only enter digits");
                                    throw new Exception("Only digits plate");
                                }
                                Console.WriteLine("How man items do you want in your stock?");
                                string StockPlate = Console.ReadLine();
                                int stockOutValue;
                                bool stockPlateResult = int.TryParse(StockPlate, out stockOutValue);
                                if (stockPlateResult)
                                {
                                    plateChoice.StockCount = stockOutValue;
                                }
                                else
                                {
                                    Console.WriteLine("You can only enter digits");
                                    throw new Exception("You can only enter digits");
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("What kind do you want to store?");
                            string obj = Console.ReadLine();
                            Console.WriteLine("How much is in your warehouse?");
                            string itemsInWarehouse = (Console.ReadLine());
                            int intValue;
                            bool stockResult = int.TryParse(itemsInWarehouse, out intValue);
                            Console.WriteLine("Inventera");
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
            Console.WriteLine("Thank you");
            Console.ReadLine();
        }
    }
}