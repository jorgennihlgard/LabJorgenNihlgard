using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    struct PointStruct
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static implicit operator Point3DStruct(PointStruct pointStruct)
        {
            return new Point3DStruct(1, 2, 3);
        }
    }
}
