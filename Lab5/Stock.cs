using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Stock
    {
        int counter = 0;
        StockItem[] stockItems = new StockItem[2] ;

        public StockItem this[int index]
        {
            get {
                if (index >= 0 && index < stockItems.Length)
                    return stockItems[index];
                else
                    throw new Exception("Out of boundery");        
            }
            private set {
                if (index >= 0 && index < stockItems.Length)
                    stockItems[index] = value;
                else
                    throw new Exception("Out of boundery");
            }
        }
       
       
        public void AddItem(StockItem item)
        {
            for (int i = 0; i < item.Length; i++)
            {
                stockItems[i] =item;
            }

          
        }
        public StockItem[] GetItem (int itemId)
        {
            Console.WriteLine(itemId);
            return stockItems;
        }

    }
}
