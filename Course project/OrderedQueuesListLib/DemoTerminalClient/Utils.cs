using OrderedQueuesListLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTerminalClient
{
    internal class Utils
    {
       public static OrderedLinkedList<string> HandGenerator ( )
        {
            OrderedQueuesListLibrary.OrderedLinkedList<string> demolist = new OrderedQueuesListLibrary.OrderedLinkedList<string>();
            Console.WriteLine("Демо список создан, выберите количество сгенерированных очередей: ");
            int queuesNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < queuesNumber + 1; i++)
            {
                Console.WriteLine("Очередь номер: " + i);
                OrderedQueuesListLibrary.Queue<string> queue = new OrderedQueuesListLibrary.Queue<string>();
                Console.WriteLine("Введите количество элементов в очерди: ");
                int elementsNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Заполнение очереди элементами");
                for (int y = 1; y < elementsNumber + 1; y++)
                {
                    String a = "string : " + y;
                    queue.Enqueue(a);
                }
                demolist.Add(queue);
            }
            return demolist;
        }

        public static OrderedLinkedList<string>AutoGenerator ( )
        {
            OrderedQueuesListLibrary.OrderedLinkedList<string> demolist = new OrderedQueuesListLibrary.OrderedLinkedList<string>();
            int queuesNumber = new Random().Next(1, 16);
            Console.WriteLine("Демо список создан, количество сгенерированных очередей: " + queuesNumber);

            for (int i = 1; i <= queuesNumber; i++)
            {
                Console.WriteLine("Очередь номер: " + i);
                OrderedQueuesListLibrary.Queue<string> queue = new OrderedQueuesListLibrary.Queue<string>();
                int elementsNumber = new Random().Next(1, 21);
                Console.WriteLine("Количество созданых элементов в очерди: " + elementsNumber);
                Console.WriteLine("Заполнение очереди элементами");
                for (int y = 1; y < elementsNumber + 1; y++)
                {
                    String a = "string : " + y;
                    queue.Enqueue(a);
                }
                demolist.Add(queue);
                Thread.Sleep(500);
            }
            return demolist;

        }

        public static void AddRandomQueue(OrderedLinkedList<string> inputList)
        {
            int rnd = new Random().Next(1, 21);
            OrderedQueuesListLibrary.Queue<string> queue = new OrderedQueuesListLibrary.Queue<string>();
            for (int y = 1; y < rnd; y++)
            {
                String a = "[ " + y + " ]";
                queue.Enqueue(a);
            }
            inputList.Add(queue);
        }

        public static void AddQueue ( OrderedLinkedList<string> inputList )
        {
            Console.Write("Введите количество элементов в очереди: ");
            int rnd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            OrderedQueuesListLibrary.Queue<string> queue = new OrderedQueuesListLibrary.Queue<string>();
            for(int y = 1; y <= rnd; y++)
            {
                Console.WriteLine("Введите значения для элемента " + y);
                try
                {
                    String a = Console.ReadLine();
                    queue.Enqueue(a);
                } catch(Exception e)
                {
                    Console.WriteLine("Ошибка ввода" + e.StackTrace);
                }
               
            }
            inputList.Add(queue);
        }

        public static void RemoveQueueFromList (OrderedLinkedList<string> inpulist)
        {
            Console.Write("Введите ID очереди для удаления: ");
            int id = Convert.ToInt32(Console.ReadLine());
            inpulist.Remove(inpulist.FindById(id));
            
        }

        public static void EnqueueIntoQueue(OrderedLinkedList<string> inpulist, int id, string value)
        {
            inpulist.FindById(id).Enqueue("[ " + value + " ]");
        }

        public static string DequeueIntoQueue(OrderedLinkedList<string> inputlist, int id)
        {
            return inputlist.FindById(id).Dequeue();
        }

        public static OrderedQueuesListLibrary.Queue<string> GetQueueById ( OrderedLinkedList<string> inputList, int Id )
        { 
            return inputList.FindById( Id );
        }

        

        public static void ShowGeneratedList ( OrderedQueuesListLibrary.OrderedLinkedList<string> inputList )
        {
            Console.WriteLine("Вывод получишвихся очередей в сортированном порядке: ");
            Console.WriteLine(inputList);

        }

        public static void ShowQueueElements(OrderedQueuesListLibrary.Queue<string> queue)
        {
            Console.WriteLine(queue);
            foreach (string element in queue)
            {
                Console.Write($"{element}" + " ");
            }
        }
    }
}
