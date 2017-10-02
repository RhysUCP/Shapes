using System;

namespace Shapes
{
    class Triangle
    {
        private double height, baseLength;

        public Triangle(double height, double baseLength)
        {
            this.height = height;
            this.baseLength = baseLength;
        }

        public double GetArea()
        {
            return height * baseLength * 0.5D;
        }

    }
}