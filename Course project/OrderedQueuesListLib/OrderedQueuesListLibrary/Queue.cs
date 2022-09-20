﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedQueuesListLibrary
{
    internal class Queue <T> : IEnumerable<T> where T : class
    {
        Node<T> head;
        Node<T> tail;
        int count;
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
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
        public T Dequeue()
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

        public T First
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
        public T Last
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

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        internal class Node <T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node (T data)
            {
                Data = data;
            }
            
        }
    }
}
