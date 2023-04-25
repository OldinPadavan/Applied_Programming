using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Объектная реализация упорядоченного списка очередей

namespace OrderedQueuesListLibrary
{
    public class OrderedLinkedList : IEnumerable<Queue<Type>>
    {
        Element head; // головной/первый элемент
        Element tail; // последний/хвостовой элемент
        static int count;  // количество элементов в списке


        public OrderedLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        // добавление элемента
        public void Add(Queue<Type> data) // поиск места вставки(сортировка на осонове длинны очереди) и вставка нового элемента
        {
            Element NewNode = new Element(data);
            Element Previous = null;
            Element Current = head;

            while (Current != null && data.Count > Current.element.Count)
            {
                Previous = Current;
                Current = Current.nextElement;
            }
            if (Previous == null)
            {
                head = NewNode;
            } else
            {
                Previous.nextElement = NewNode;
            }
            NewNode.nextElement = Current;
            count++;
        }
        // удаление элемента
        public bool Remove(Queue<Type> data)
        {
            Element current = head;
            Element previous = null;

            while (current != null)
            {
                if (current.element.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.nextElement = current.nextElement;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.nextElement == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.nextElement;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.nextElement;
            }
            return false;
        }

        public void Print()
        {
            if (!IsEmpty)
            {
                Element current = head;
                while (current != null)
                {
                    foreach(Type element in current.element)
                    {
                        Console.WriteLine(element.ToString);
                    }
                    current = current.nextElement;
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }

        public static int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        // очистка списка
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
        // содержит ли список элемент
        public bool Contains(Queue<Type> data)
        {
            Element current = head;
            while (current != null)
            {
                if (current.element.Equals(data))
                    return true;
                current = current.nextElement;
            }
            return false;
        }
        // добвление в начало

        // реализация интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<Queue<Type>> IEnumerable<Queue<Type>>.GetEnumerator()
        {
            Element current = head;
            while (current != null)
            {
                yield return current.element;
                current = current.nextElement;
            }
        }
        class Element
        {
            public Queue<Type> element { get; set; }
            public Element nextElement { get; set; }
            private int ElementId;

            public Element (Queue<Type> element)
            {
                this.element = element;
                this.ElementId = Count;
               
            }

            public override string ToString ( )
            {
                return "Номер очереди = " + ElementId + ", количество элементов в очереди: " + element.Count;
            }

        }
    }
}
