using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class User
    {
        private int nrOfHands;
        private string occupation;

        public void SetNrOfHands(int nrOfHands)
        {
            this.nrOfHands = nrOfHands;
        }

        public int GetNrOfHands()
        {
            return nrOfHands;
        }
        public void SetOccupation(string occupation)
        {
            this.occupation = occupation;
        }
        public string GetOccupation()
        {
            return occupation;
        }
    }

}
