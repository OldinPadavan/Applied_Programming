using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedQueuesListLibrary
{
    public class Queue <K> : IEnumerable<K> where K : class
    {
        Node<K> head;
        Node<K> tail;
        int count;


        public Queue()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void Enqueue(K data) // добавление в очередь
        {
            Node<K> node = new Node<K>(data);
            Node<K> tempNode = tail;
            tail = node;
            if (count == 0)
            {
                head = tail;
            } else
            {
                tempNode.Next = tail;
            }
            count++;
        }
        public K Dequeue() //удаление из очереди
        {
            if (count == 0)
            {
                throw new InvalidOperationException();
            }
            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public K First
        {
            get
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException();
                } else
                {
                    return head.Data;
                }
            }
        }
        public K Last
        {
            get
            {
                if (IsEmpty)
                {
                    throw new InvalidOperationException();
                } else
                {
                    return tail.Data;
                }
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return count == 0;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<K> IEnumerable<K>.GetEnumerator()
        {
            Node<K> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        class Node <T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node (T data)
            {
                Data = data;
            }

            public override string ToString ( )
            {
                return Data.ToString();
            }

        }
    }
}
