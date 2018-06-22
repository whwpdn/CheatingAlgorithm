using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CheatingAlgorithm
{
    public class CheatingAlgorithm
    {
        public void InsertionSort(ref int [] data)
        {
            
            int size = data.Length;
            Console.WriteLine(size);
        }
    }

    

    class Node<T>
    {
        public Node(T data)
        {
            this.data = data;
        }
        public T data { get; set; }
        public Node<T> Next { get; set; }
    }

    public class DataStructure<T>
    {
        protected T[] data;
        protected int max;
        protected int index = -1;
        //protected DataStructure()
        //{

        //}
        protected DataStructure(int size)
        {
            max = size;
            this.data = new T[size];
        }
        public int Size
        {
            get { return index; }
        }
        public bool IsEmpty
        {
            get { return index < 0 ? true : false; }
        }
        public bool IsFull
        {
            get { return index < (max - 1) ? false : true; }
        }
        // for test
        public T[] Clone()
        {
            if (index < 0)
                return null;
            T[] data = new T[index + 1];
            for (int i = 0; i <= index; i++)
            {
                data[i] = this.data[i];
            }
            return data;
        }
    }
    // queue
    public class CheatingQueue<T> : DataStructure<T>
    {
        int front = 0;
        public CheatingQueue(int size):base(size)
        {
            
        }

        public void Push(T data)
        {
            if (IsFull)
            {
                throw new Exception("Queue is full");
                
            }
            else
            {
                index++;
                this.data[index] = data;
            }
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("stack is empty");
                
            }
            else
            {
                T popdata = this.data[0];
                ShiftQueue();
                index--;
                return popdata;
            }
        }
        private void ShiftQueue()
        {
            for(int i=0; i< index ; i++)
            {
                this.data[i] = this.data[i + 1];
            }
        }
    }
    // stack
    public class CheatingStack<T> : DataStructure<T>
    {
        int top = 0;
        public CheatingStack(int size) :base(size)
        {
            
        }

        public void Push(T data)
        {
            if (IsFull)
            {
                throw new Exception("stack is full");
                
            }
            else
            {
                index++;
                this.data[index] = data;
                top++;
            }
        }

        public T Pop()
        {
            if(index >-1)
            {
                T popdata = data[top];
                index--;
                top--;
                return popdata;
            }
            else
            {
                throw new Exception("stack is empty");
            }
        }
    }
    // one way linkedlist 
    public class CheatingLinkedList<T>
    {
        Node<T> Head;
        int size = 0;

        public void PushBack(T data)
        {

            Node<T> node = new Node<T>( data);
            if(this.Head == null)
            {
                this.Head = node;
                size = 1;
            }
            else
            {
                node.Next = this.Head;
                this.Head = node;
                size++;
            }
            
        }
        public T PopFront()
        {
            if (this.Head == null) return Head.data;
            
            size--;
            Node<T> data = this.Head;
            this.Head = this.Head.Next;
            return data.data;
        }

    
       
    }
}
