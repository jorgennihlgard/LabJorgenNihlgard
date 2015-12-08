using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Juice : EcoStockItem 
    {
        private string juiceSort;
    
        public string Sort
        {
            get { return juiceSort; }
            set {if (value == "Apple" || value == "Orange")
                    juiceSort = value;
                else
                    throw new Exception("Only Apple and Orange is available");
            }
        }
        public override string ToString()
        {
            return ($"Sort {juiceSort} "+base.ToString());
        }

    }
}
