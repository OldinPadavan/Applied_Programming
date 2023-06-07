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

        private void RunCurrentListMenu()
        {
            Utils.ShowGeneratedList(demoList);
            string prompt = "Выберите операцию: ";
            string[] options = { "Добавать очередь(ручной ввод)", "Добавить очередь(автогенерация)", "Выбрать очередь", "Удалить очередь", "Вернуться в главное меню" };
            ChooseQueuesMenu chooseQueuesMenu = new ChooseQueuesMenu(prompt, options, demoList);
            int selectedIndex = chooseQueuesMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Utils.AddQueue(demoList);
                    break;
                case 1:
                    Utils.AddRandomQueue(demoList);
                    break;
                case 2:
                    Console.Write("Введите ID для выбора очереди: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    RunQueueMenu(id);
                    break;
                case 3:
                    Utils.RemoveQueueFromList(demoList);
                    RunCurrentListMenu();
                    break;
                case 4:
                    RunMainMenu();
                    break;

            }
            RunCurrentListMenu();
        }

        private void RunQueueMenu (int id)
        {
            OrderedQueuesListLibrary.Queue<string> SelectedQueue = demoList.FindById(id);
            string[] options = { "Положить элемент", "Взять элемент", "Вернуться в список очередей"};
            QueueMenu QueueMenu = new QueueMenu(options, SelectedQueue);
            int selectedIndex = QueueMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Console.Write("Введите значение для вставки: ");
                    string value = Console.ReadLine();
                    Console.WriteLine();
                    Utils.EnqueueIntoQueue(SelectedQueue, value);
                    break;
                case 1:
                    Console.WriteLine("Взятое значение = " + Utils.DequeueIntoQueue(SelectedQueue));
                    Thread.Sleep(500);
                    break;
                case 2:
                    RunCurrentListMenu();
                    break;

            }
            RunQueueMenu(id);
        }

        private void AutoGenerator()
        {
            demoList = Utils.AutoGenerator();

            RunCurrentListMenu();
        }

        private void HandGenerator()
        {
            demoList = Utils.HandGenerator();
            RunCurrentListMenu();
        }

        private void Exit ( )
        {
            Console.WriteLine("\nНажмите любую клавишу для выхода");
            Console.ReadKey(true);
            Environment.Exit(0);
            
        }

    }
}
