using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Two
{
    class Rectangle // базовый класс
    {
/*<<<<<<< HEAD
=======*/
        private double length;
        private double width;

        public Rectangle() // конструктор по умолчанию 
        {
            length = 5.0;
            width = 4.0;
        }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double getLength() // геттеры
        {
            return this.length;
        }

        public double getWidth()
        {
            return this.width;
        }

        public void setLength(double length) // сеттеры
        {
            this.length = length;
        }

        public void setWidth(double width)
        {
            this.width = width;
        }

        public override string ToString() // вывод в консоль
        {
            return "It is Rectangle object, length = " + this.length + " , width = " + this.width;
        }

        public virtual double getArea() // расчет площади
        {
            return this.length * this.width;
        }

        public virtual double getPerimeter() //расчет периметра
        {
            return 2 * (this.length + this.width);
        }

        /*>>>>>>> 7636fd8e56753b5eab83cd2b18ef173d7d179091*/
    }
}
