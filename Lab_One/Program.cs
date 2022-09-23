using System;

namespace Lab_One
{
    class Program
    {
        static void Main(string[] args)
        {
            showMenu();
        }

        public static void calculatOfCircleArea()
        {
            Console.WriteLine("Введите радиус окружности:");
            double r = Convert.ToDouble(Console.ReadLine());
            if (r > 0)
            {
                Console.WriteLine("Ответ : " + Math.PI * Math.Pow(r, 2));

            }
            else
            {
                Console.WriteLine("Ошибка аргумента, перезапустите программу");
            }

        }

        public static void calculatOfCircleLenght()
        {
            Console.WriteLine("Введите радиус окружности:");
            double r = Convert.ToDouble(Console.ReadLine());
            if (r > 0)
            {
                Console.WriteLine("Ответ : " + 2 * (Math.PI * r));

            }
            else
            {
                Console.WriteLine("Ошибка аргумента, перезапустите программу");
            }

        }

        public static void showMenu()
        {
            Console.WriteLine("Выберите тип операции, введите номер операции:");
            Console.WriteLine(" Для \"Нахождения площади круга\": 1\n Для \"Нахождения длины окружности нажмите\": 2 ");
            int commandNumber;
            try
            {
                 commandNumber = Convert.ToInt32(Console.ReadLine());
            } catch
            {
                Console.WriteLine("Неккоректное значение");
                commandNumber = 0;
            }
            switch (commandNumber)
            {
                case 1:
                    calculatOfCircleArea();
                    break;
                case 2:
                    calculatOfCircleLenght();
                    break;
                default: Console.WriteLine("Неизвестная команда");
                    break;
            }

        }
    }
}
