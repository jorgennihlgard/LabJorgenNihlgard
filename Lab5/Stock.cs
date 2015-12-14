using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
   internal class Stock
    {
       private int counter = 0;
      internal  StockItem[] stockItems = new StockItem[10] ;

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
            
            this[counter] =item;
            counter++;
        }




       public StockItem GetItem(int itemId)
       {
           return stockItems[itemId];
         
       }


       }
}
