using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Объектная реализация упорядоченного списка очередей

namespace OrderedQueuesListLibrary
{
    public class OrderedLinkedList<T> : IEnumerable<OrderedQueuesListLibrary.Queue<T>>
    {
        private Element head; // головной/первый элемент
        private Element tail; // последний/хвостовой элемент
        private static int count;  // количество элементов в списке


        public OrderedLinkedList ( )
        {
            head = null;
            tail = null;
            count = 0;
        }

        // добавление элемента
        public void Add (Queue<T> data ) // поиск места вставки(сортировка на осонове длинны очереди) и вставка нового элемента
        {
            Element NewNode = new Element(data);
            Element Previous = null;
            Element Current = head;

            while (Current != null && data.Count > Current.Data.Count)
            {
                Previous = Current;
                Current = Current.Next;
            }
            if (Previous == null)
            {
                head = NewNode;
            } else
            {
                Previous.Next = NewNode;
            }
            NewNode.Next = Current;
            count++;
        }
        // удаление элемента
        public bool Remove ( Queue<T> data )
        {
            Element current = head;
            Element previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    // Если узел в середине или в конце
                    if (previous != null)
                    {
                        // убираем узел current, теперь previous ссылается не на current, а на current.Next
                        previous.Next = current.Next;

                        // Если current.Next не установлен, значит узел последний,
                        // изменяем переменную tail
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        // если удаляется первый элемент
                        // переустанавливаем значение head
                        head = head.Next;

                        // если после удаления список пуст, сбрасываем tail
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void Print ( )
        {
            if (!IsEmpty)
            {
                Element current = head;
                while (current != null)
                {
                    Console.WriteLine(current.ToString);
                    current = current.Next;
                }
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }

        public  int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        // очистка списка
        public void Clear ( )
        {
            head = null;
            tail = null;
            count = 0;
        }
        // содержит ли список элемент
        public bool Contains ( Queue<T> data )
        {
            Element current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public override string ToString ( )
        {
            string allElements = "";
            Element current = head;
            while (current != null)
            {
                allElements = allElements + current.ToString() + "\n";
                current = current.Next;
                
            }
            return allElements;
        }

        public OrderedQueuesListLibrary.Queue<T> FindById(int id)
        {
            Element current = head;
            while (current != null)
            {
                if (current.ElementId == id)
                {
                    return current.Data;
                }
                current = current.Next;
            }
            return null;
        }


        IEnumerator IEnumerable.GetEnumerator ( )
        {
            return ((IEnumerable<T>)this).GetEnumerator();
        }

        public IEnumerator<Queue<T>> GetEnumerator ( )
        {
            Element current = head;
            while (current != null)
            {
                yield return (Queue<T>)current.Data;
                current = current.Next;
            };
        }

        class Element
        {
            public Queue<T> Data { get; set; }
            public Element Next { get; set; }
            public Element Previous { get; set; }
            public int ElementId { get; set; }


            public Element (Queue<T> data)
            {
                this.Data = data;
                this.ElementId = count + 1;
               
            }

            public override string ToString ( )
            {
                return "Очедь Id = " + ElementId + " " + this.Data.ToString();
            }

        }
    }
}
