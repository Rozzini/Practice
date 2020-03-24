using System;


namespace Practice1.LinkedList
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node(T data)
        {
            Data = data;
            Next = null;
        }

        public void AddToLast(T data)
        {
            if(Next == null)
            {
                Next = new Node<T>(data);
            }
            else
            {
                Next.AddToLast(data);
            }             
        }

       
        public void DeleteNext()
        {
            Node<T> FirstAfter = this.Next;
            Node<T> SecondAfter = FirstAfter.Next;
            if(FirstAfter != null)
            {
                this.Next = null;
                if(SecondAfter != null)
                {
                    this.Next = SecondAfter;                   
                }

            }

        }
    }
}


