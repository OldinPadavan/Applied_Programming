using System.Runtime.Serialization.Formatters;

public class TerminalDemoGUI
{
    public static void Main ( string[] args)
    {
        InvokeMenu();
    }

    static void InvokeMenu()
    {
        int ChoosedCommand = 0;
        Console.WriteLine("Визуальная демонстрация работы упорядоченного списка очередей");
        Console.WriteLine("Выберите режим работы:");
        Console.WriteLine("1: Режим автогенерации количества списков и очередей");
        Console.WriteLine("2: Режим ручного создания списков и очередей");
        Console.WriteLine("3: Выход из программы");
        Console.WriteLine("");
        Console.WriteLine("Для выбора введите номер операции");
        Console.WriteLine("");
        try
        {
            switch (Console.ReadLine())
            {
                case "1":
                    AutoGenerator();
                    break;
                case "2":
                    HandGenerator();
                    break;
                case "3":
                    break;
                default:
                    break;
            }
        } catch (IOException exception) 
        {
            Console.WriteLine("Вы ввели некорректную комманду, программа была завершена. Код ошибки:" + exception.ToString());
        }

    }


    static void HandGenerator()
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
        ShowResult(demolist);
    }

    static void AutoGenerator()
    {

    }

    static void ShowResult(OrderedQueuesListLibrary.OrderedLinkedList<string> inputList)
    {
        Console.WriteLine("Вывод получишвихся очередей в сортированном порядке: ");
        foreach (OrderedQueuesListLibrary.Queue<string>queue in inputList)
        {
            queue.ToString();
        }
    }
}
