using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Person
    {
        private string name;

        public void SetName(string name)
        {
            if (name != null)
                this.name = name;
            throw new Exception("Du kan inte skick in en sträng som är null");
        }

        public string GetName()
        {
            return name;
        }
    }
}
