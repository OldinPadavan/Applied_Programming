using System.Data;

namespace EducationPractice

{
    /// <summary>
    /// Testing class with basic commands
    /// </summary>
    public class Program
    {
        /// <value>
        /// variable declaration for input 
        /// </value>
        public int input;

        /// <summary>
        /// main method
        /// </summary>
        public static void Main()
        {
            int x = 5;
            Program program= new Program();
            program.input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello World!");
            //foreach (char ch in "Hello World!")
            //{
            //    Console.WriteLine(ch);
            //}

            Console.WriteLine(program.Sum(x));
            Console.WriteLine(x);
            try
            {
                Console.WriteLine(x / program.input);
            } catch(DivideByZeroException exception)
            {
                Console.WriteLine("I tried to divided first number to zero " + " " + exception.Message);
            }
        }

        /// <summary>
        /// test summary method
        /// </summary>
        /// <param name="x"></param>
        /// <returns> sum of two int value</returns>
        public int Sum(int x)
        {
            int g = 10;
            x += 5;
            return x + g;
        }

        /// <summary>
        /// recursive call example
        /// </summary>
        public void Zuu ( )
        {
            Zuu( );
        }

        /// <summary>
        /// test method with two parameters and another method call
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void Fuu(int a, int b)
        {
            Zuu ( );
        }
        

    }
}