using System;
using System.Collections;
using System.Collections.Generic;

namespace Practice1.DoublyLinkedList
{
    internal class DoubleLinkedList<T>: IEnumerable<T>
    {
        internal DNode<T> head;

        public void AddWithWhile(T data)
        {
            DNode<T> Node = new DNode<T>(data);
            if (head == null)
            {
                head = Node;
            }
            else
            {
                DNode<T> lastNode = GetLastNode();
                lastNode.Next = Node;
                Node.Prev = lastNode;
            }
        }
      

        
        public void Remove(T data)
        {
            DNode<T> current = head;
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

        private DNode<T> GetLastNode()
        {
            DNode<T> temp = head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }

        
        public void PrintList()
        {
            DNode<T> temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }

        public void PrintReverseList()
        {
            DNode<T> temp = GetLastNode();
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Prev;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            DNode<T> temp = head;
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
