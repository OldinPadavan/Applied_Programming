﻿using System;

namespace Lab_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle();
            Console.WriteLine(rectangle1.ToString());
            Console.WriteLine(rectangle1.getArea());

            Rectangle rectangle2 = new Rectangle(12.0, 9.0);
            Console.WriteLine(rectangle2.ToString());
            Console.WriteLine(rectangle2.getArea());

            Parallelepiped parallelepiped1 = new Parallelepiped();
            Console.WriteLine(parallelepiped1.ToString());
            Console.WriteLine(parallelepiped1.getArea());
            Console.WriteLine(parallelepiped1.getVolume());

            Parallelepiped parallelepiped2 = new Parallelepiped(8.0, 5.9, 7.0);
            Console.WriteLine(parallelepiped2.ToString());
            Console.WriteLine(parallelepiped2.getArea());
            Console.WriteLine(parallelepiped2.getVolume());

            Pyramid pyramid1 = new Pyramid();
            Console.WriteLine(pyramid1.ToString());
            Console.WriteLine(pyramid1.getArea());
            Console.WriteLine(pyramid1.getVolume());

            Pyramid pyramid2 = new Pyramid(12.2, 9.4, 6.1);
            Console.WriteLine(pyramid2.ToString());
            Console.WriteLine(pyramid2.getArea());
            Console.WriteLine(pyramid2.getVolume());


        }
    }
}
