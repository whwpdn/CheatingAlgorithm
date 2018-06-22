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

    // stack
    public class CheatingStack<T>
    {
        T[] data;
        int top =-1;
        int max;
        public int Size
        {
            get{return top;}
        }
        public bool IsEmpty
        {
            get { return top<0? true : false; }
        }
        public bool IsFull
        {
            get { return top < (max-1) ? false : true; }
        }
        
        // for test
        public T[] Clone()
        {
            if (top < 0)
                return null;
            T[] data = new T[top+1];
            for (int i = 0; i <= top; i++)
            {
                data[i] = this.data[i];
            }
                return data;
        }

        public CheatingStack(int size)
        {
            max = size;
            this.data = new T[size];
        }

        public void Push(T data)
        {
            if (max > top)
            {
                top++;
                this.data[top] = data;
            }
            else
            {
                throw new Exception("stack is full");
            }
        }

        public T Pop()
        {
            if(top >-1)
            {
                T popdata = data[top];
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
