using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Juice : EcoStockItem 
    {
        private string sort;

        public string Sort
        {
            get { return sort; }
            set {if (value == "Apple" || value == "Orange")
                    sort = value;
                else
                    throw new Exception("Only Apple and Orange is available");
            }
        }
        public override string ToString()
        {
            return ($"Sort {sort} "+base.ToString());
        }

    }
}
