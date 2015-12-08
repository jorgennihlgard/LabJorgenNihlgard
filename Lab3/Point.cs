using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
   public class Point
    {
        private int y;
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point()
        {
            Y = 2;
            X = 3;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Nedan get/set metoder istället


        public void SetX(int x)
        {
            this.x = x;
        }

        public int GetX()
        {
            return x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public int GetY()
        {
            return y;
        }
    }
}
