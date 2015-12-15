using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class EcoStockItem : StockItem
    {
        private string mark;

        public string Mark
        {
            get { return mark; }
            set  {
                if (value.ToLower() == "abio" || value.ToLower() == "ab")
                    mark = value;
                else
                {
                    throw new Exception("Only ABIO and AB is accepted ECO labels");
                }
            }
        }
        public override string ToString()
        {
            return ($" Mark: {Mark} "+base.ToString());
        }
    }
}
