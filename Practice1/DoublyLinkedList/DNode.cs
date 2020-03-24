using System;


namespace Practice1.DoublyLinkedList
{
    public class DNode<T>
    {        
        public T Data { get; set; }
        public DNode<T> Next { get; set; }

        public DNode<T> Prev { get; set; }
        public DNode(T data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
       

        public void DeleteNext()
        {
            DNode<T> FirstAfter = this.Next;
            DNode<T> SecondAfter = FirstAfter.Next;
            if (FirstAfter != null)
            {
                this.Next = null;
                if (SecondAfter != null)
                {
                    this.Next = SecondAfter;
                    SecondAfter.Prev = FirstAfter;
                }

            }

        }
    }
}
