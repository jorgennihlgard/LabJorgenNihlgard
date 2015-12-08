using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class StockItem
    {
        private int id;
        private string name;
        private int stockCount;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Length { get; internal set; }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int StockCount
        {
            get { return stockCount; }
            set { stockCount = value; }
        }


        public override string ToString()
        {
            return ($"Id: {id} Name: {Name} Stockcount: {stockCount}");
        }

    }
}
