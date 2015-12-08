using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Circle
    {
        private double diameter;
        private Point center;

        public void SetDiameter(double diameter)
        {
            this.diameter = diameter;
        }

        public double GetDiameter()
        {
            return diameter;
        }

        public double GetCircumference()
        {
            return Math.PI * diameter;
        }

        public void SetCenter(Point point)
        {
            center = point;
        }

        public Point GetCenter()
        {
            return center;
        }

    }
}
