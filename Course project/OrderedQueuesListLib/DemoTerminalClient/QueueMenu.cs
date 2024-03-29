﻿using OrderedQueuesListLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTerminalClient
{
    internal class QueueMenu
    {
        private int SelectedIndex;
        private string[] Options;
        private OrderedQueuesListLibrary.Queue<string> queue;

        public QueueMenu (string[] options, OrderedQueuesListLibrary.Queue<string> queue )
        {
            Options = options;
            SelectedIndex = 0;
            this.queue = queue;
        }

        private void DisplayOptions ( )
        {

            Utils.ShowQueueElements(queue);
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
