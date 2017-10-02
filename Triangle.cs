using System;

namespace Shapes
{
    class Triangle
    {
        private double height, baseLength;

        public Triangle()
        {}

        public double GetArea()
        {
            return height * baseLength * 0.5D;
        }

        public double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value < 0 || value > double.MaxValue)
                    throw new OverflowException();

                height = value;
            }
        }

        public double BaseLength
        {
            get
            {
                return baseLength;
            }

            set
            {
                if (value < 0 || value > double.MaxValue)
                    throw new OverflowException();

                baseLength = value;
            }
        }

    }
}