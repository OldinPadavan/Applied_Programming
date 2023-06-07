using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTerminalClient
{
    internal class ChooseQueuesMenu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;
        private OrderedQueuesListLibrary.OrderedLinkedList<string> inputList;

        public ChooseQueuesMenu ( string prompt, string[] options, OrderedQueuesListLibrary.OrderedLinkedList<string> inputList )
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
            this.inputList = inputList;
        }

        private void DisplayOptions ()
        {
            Utils.ShowGeneratedList(inputList);
            Console.WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOptions = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = "*";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"{prefix}<< {currentOptions} >>");
            }
            Console.ResetColor();
        }
        public int Run ( )
        {
            ConsoleKey keyPressed;

            do
            {
                Console.Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);

            return SelectedIndex;
        }
    }
}
