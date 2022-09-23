using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Two
{
    class Parallelepiped : Rectangle
    {
        private double height;

        public Parallelepiped() : base() // конструтор по умолчанию, с вызовом конструктора базового класса и инициализацией нового поля
        {
            height = 7.0;
        }

        public Parallelepiped(double length, double wigth, double height) : base(length, wigth)
        {
            this.height = height;
        }

        public double Height //геттер и сеттер в более компактном виде
        {
            get { return height; }
            set { height = value;}
        }

        public override string ToString()
        {
            return "It is Parallelepiped object, length = " + this.getLength() + " , width = " + this.getWidth() + ", height = " + this.Height;
        }

        public override double getArea() // переопределенный метод getArea()
        {
            return 2 * base.getArea() + (base.getPerimeter() * this.height);
        }
        public double getVolume()
        {
            return base.getArea() * this.height;
        }
        

    }
}
