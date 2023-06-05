using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTerminalClient
{
    internal class App
    {
        private OrderedQueuesListLibrary.OrderedLinkedList<string> demoList;
        public void Start ( )
        {
            Console.Title = "Queue Generator";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = @"  ____                                           _____                                        _                  
  / __ \                                         / ____|                                      | |                 
 | |  | |  _   _    ___   _   _    ___   ___    | |  __    ___   _ __     ___   _ __    __ _  | |_    ___    _ __ 
 | |  | | | | | |  / _ \ | | | |  / _ \ / __|   | | |_ |  / _ \ | '_ \   / _ \ | '__|  / _` | | __|  / _ \  | '__|
 | |__| | | |_| | |  __/ | |_| | |  __/ \__ \   | |__| | |  __/ | | | | |  __/ | |    | (_| | | |_  | (_) | | |   
  \___\_\  \__,_|  \___|  \__,_|  \___| |___/    \_____|  \___| |_| |_|  \___| |_|     \__,_|  \__|  \___/  |_|   
    Termial GUI demonstarion program for OrderedQueueList class: ver. 0.1(aplha)" + "\n";
           
            string[] options = { "Автогенерация очередей", "Ручное создание очередей", "Выход" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0: 
                    AutoGenerator();
                    break;
                case 1:
                    HandGenerator();
                    break;
                case 2:
                    Exit();
                    break;

            }

        }

        private void AutoGenerator()
        {
            demoList = Utils.AutoGenerator();
            Utils.ShowResult(demoList);
        }

        private void HandGenerator()
        {
            demoList = Utils.HandGenerator();
            Utils.ShowResult(demoList);     
        }

        private void Exit ( )
        {
            Console.WriteLine("\nНажмите любую клавишу для выхода");
            Console.ReadKey(true);
            Environment.Exit(0);
            
        }

    }
}
