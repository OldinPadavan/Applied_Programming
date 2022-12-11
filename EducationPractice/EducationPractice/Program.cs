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
        public int Input;

        /// <summary>
        /// main method
        /// </summary>
        public static void Main()
        {
            int x = 5;
            Program Program= new Program();
            Program.Input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello World!");
            //foreach (char ch in "Hello World!")
            //{
            //    Console.WriteLine(ch);
            //}

            Console.WriteLine(Program.Sum(x));
            Console.WriteLine(x);
            try
            {
                if (Program.Input == 0)
                {
                    Console.WriteLine("input var = 0");
                }
                else
                {
                    if (Program.Input % 2 == 0)
                    {
                        Console.WriteLine("even");
                    } else
                    {
                        Console.WriteLine("odd");
                    }
                }

                Console.WriteLine(x / Program.Input);
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
        

        //N = 21
        //CA = 4
        //Lloop = 0
        //LIF = 2
        //Lmod = 3
        //CL = 4/21 = 0.19 (CA/N)
        

    }
}