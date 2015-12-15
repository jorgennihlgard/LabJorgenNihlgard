using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    struct Point3DStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3DStruct(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static explicit operator PointStruct(Point3DStruct point3DStruct)
        {
            return new PointStruct(7,4);
        }
    }
}
