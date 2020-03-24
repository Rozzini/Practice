using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice1.LinkedList
{
    public class SingleLinkedList<T> : IEnumerable<T>
    {
        public Node<T> head;

        public void AddWithWhile(T data)
        {
            Node<T> Node = new Node<T>(data);
            if (head == null)
            {
                head = Node;
            }
            else
            {
                Node<T> lastNode = GetLastNode();
                lastNode.Next = Node;               
            }
        }

        public void AddWithRecursion(T data)
        {
            if (head == null)
            {
                head = new Node<T>(data);
            }
            else
            {
                head.AddToLast(data);
            }
            
        }
        public void Remove(T data)
        {
            Node<T> current = head;
            do
            {                
                var Next = current.Next;
                var currentData = Next.Data;
                if (EqualityComparer<T>.Default.Equals(currentData, data))
                {
                    current.DeleteNext();
                    break;
                }
                current = current.Next;
            } while (current != null);
        }

        public void Clear()
        {      
            
             head = null;
           
        }

        private Node<T> GetLastNode()
        {
            Node<T> temp = head;
            
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }


        public void PrintList ()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                yield return temp.Data; 
                temp = temp.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

      
    }
}
