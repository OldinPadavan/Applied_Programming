using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Two
{
    class Pyramid : Rectangle
    {
        private double height;
        private double height_of_side;

        public Pyramid() : base()
        {
            height = 8.0;
            height_of_side = height + 3.0;
        }

        public Pyramid(double length, double wigth, double height) : base(length, wigth)
        {
            this.height = height;
            height_of_side = height + 3.0;
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double SideHeight
        {
            get { return height_of_side; }
        }

        public override string ToString()
        {
            return "It is Pyramid object, length = " + this.getLength() + " , width = " + this.getWidth() + ", height = " + this.Height + ", the side's height = " + SideHeight;
        }

        public override double getArea()
        {
            return 4 * (0.5 * (base.getArea() * this.height_of_side));
        }
        public double getVolume()
        {
            return 0.3333 * (base.getArea() * this.height);
        }
    }
}
