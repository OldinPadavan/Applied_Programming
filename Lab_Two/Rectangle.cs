using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Two
{
    class Rectangle
    {
<<<<<<< HEAD
=======
        private double length;
        private double width;

        public Rectangle()
        {
            length = 5;
            width = 4;
        }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double getLength()
        {
            return this.length;
        }

        public double getWidth()
        {
            return this.width;
        }

        public void setLength(double length)
        {
            this.length = length;
        }

        public void setWidth(double width)
        {
            this.width = width;
        }

        public override string ToString()
        {
            return "Rectangle's length = " + this.length + " , width = " + this.width;
        }

        public virtual double getPerimeter(double length, double width)
        {
            return 2*(length + width);
        }

        public virtual double getArea(double length, double width)
        {
            return length * width;
        }

>>>>>>> 7636fd8e56753b5eab83cd2b18ef173d7d179091
    }
}
