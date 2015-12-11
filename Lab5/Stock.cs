using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
   public class Stock
    {
       private int counter = 0;
      internal  StockItem[] stockItems = new StockItem[6] ;

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

           for (int i = 0; i < stockItems.Length; i++)
           {
               if (stockItems[i].Id == itemId && stockItems[i]!= null)
                   return stockItems[i];

            }
            throw new Exception("Finns ingen med det id:et");
        }


    }
}
