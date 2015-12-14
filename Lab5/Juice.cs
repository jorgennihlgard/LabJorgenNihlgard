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
                        
        public string JuiceSort
        {
            get { return juiceSort; }
            set {if (value.ToLower() == "apple" || value.ToLower() == "orange")
                    juiceSort = value;
                else
                    throw new Exception("Only Apple and Orange is available");
            }
        }

        //public string Ju { get; private set; }

        //public Juice()

        //{
            
        //}
        //public Juice(string ju)
        //{
        //    Ju = ju;

        //}
        public override string ToString()
        {
            return ($"Juicesort {juiceSort} "+base.ToString());
        }

    }
}
