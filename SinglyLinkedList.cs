using System;

namespace Practice_algo
{
    public class SinglyLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }

        public int Count { get; private set; }


        public void AddFirst(T value)
        {
            AddFirst(new Node<T>(value));
        }

        private void AddFirst(Node<T> node)
        {
            //save the current head
            Node<T> temp = Head;
            Head = node;
            //Shifting the former head
            Head.Next = temp;

            Count++;
            if(Count == 1)
            {
                Tail = Head;
            }
        }


        public void Addlast(T value)
        {
            Addlast(new Node<T>(value));
        }

        private void Addlast(Node<T> node)
        {
            if (IsEmpty)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            Head = Head.Next;
            
            if(Count == 1)
            {
                Tail = null;
            }
            Count--;
        }

        public void RemoveLast()
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            if (Count == 1)
                Head = Tail = null;
            else
            {
                //find the penultimate node;
                var current = Head;
                while(current.Next != Tail)
                {
                    current = current.Next;
                }

                current.Next = null;
                Tail = current;

                Count--;
            }
        }


        public bool IsEmpty => Count == 0;
    }
}
