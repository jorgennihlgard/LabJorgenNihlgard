﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Plate : StockItem
    {
        private string sort;

        public string Sort


        {
            get { return sort; }
            set { if (value == "Deep" && value == "Flat")
                    sort = value;
                else
                    throw new Exception("Only deep and flat is available");
                }
        }
        public override string ToString()
        {
            return ($"deep or flat {sort}"+base.ToString());
        }
    }
}