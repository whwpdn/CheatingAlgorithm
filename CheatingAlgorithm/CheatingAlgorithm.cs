﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CheatingAlgorithm
{
    public static class CheatingAlgorithm
    {
        public static int[] InsertionSort(this int[] data)
        {
            int size = data.Length;
            int[] sortedData = (int[])data.Clone();
            for (int i = 1; i < size; i++ )
            {
                int tempData = sortedData[i];
                for(int j = i; j > 0; j--)
                {
                    if (sortedData[j - 1] > tempData)
                    {
                        sortedData[j] = sortedData[j - 1];
                        sortedData[j - 1] = tempData;
                    }
                    else
                        break;
                }
            }

            return sortedData;
        }
        public static int [] InsertionSortTest(this int[] data ,int tempData, ref int inIdx)
        {
            int[] sortedData = (int[])data.Clone();
            //int tempData = sortedData[outIdx];

            if (sortedData[inIdx - 1] > tempData)
            {
                sortedData[inIdx] = sortedData[inIdx - 1];
                sortedData[inIdx - 1] = tempData;
                inIdx--;
            }
            else
                inIdx = 0;

            return sortedData;

        }
        public static int[] SelectionSort(this int[] data)
        {
            int size = data.Length;
            int[] sortedData = (int[])data.Clone();
            for (int i = 0; i < size; i++)
            {
                int min = i;
                for(int j= i+1 ; j< size ; j++)
                {
                    if(sortedData[min] > sortedData[j])
                    {
                        min = j;
                    }
                }
                swap(ref sortedData[min], ref sortedData[i]);
            }

            return sortedData;
        }
        public static int [] SelectionSortTest(this int[] data ,ref int outIdx , ref int inIdx , ref int min)
        {
            int[] sortedData = (int[])data.Clone();

            if (sortedData[min] > sortedData[inIdx])
            {
                min = inIdx;
            }
            
            inIdx++;

            if(inIdx >= sortedData.Length)    
            {
                swap(ref sortedData[min], ref sortedData[outIdx]);
                min = ++outIdx;
                inIdx = outIdx+1;
            }
            
            return sortedData;
        }

        /// <summary>
        /// BubbleSort
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int[] BubbleSort(this int[] data)
        {
            int size = data.Length;
            int[] sortedData = (int[])data.Clone();
            //int [] sortedData = new int[size];
            //sortedData = CopyByValue(sortedData, data);
            for (int i = 1; i < size; i++ )
            {
                for(int j= 0; j< (size-i);j++)
                {
                    if (sortedData[j] > sortedData[j + 1])
                        swap(ref sortedData[j], ref sortedData[j + 1]);
                }
            }
            
            return sortedData;
        }
        /// <summary>
        /// mergesort
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int[] MergeSort(this int[] data)
        {
            int[] sortedData = (int[])data.Clone();
            DivideArray(sortedData, 0, ( data.Length-1));
            return sortedData;
        }

        public static void DivideArray(int[] data, int startIdx  , int endIdx )
        {
            
            if(startIdx < endIdx)
            {
                int middleIdx = (startIdx + endIdx) / 2;
                // 중간으로나눠서 재귀
                DivideArray(data, startIdx, middleIdx);
                DivideArray(data, middleIdx+1, endIdx);

                // 합쳐
                MergeArray(data, startIdx, endIdx, middleIdx);
            }


        }

        private static void MergeArray(int [] data, int startIdx , int endIdx , int middleIdx)
        {
            int[] result = new int[data.Length]; 
            int i = startIdx;
            int j = middleIdx+1;
            int copy =0;
            
            while ( i <= middleIdx && j <= endIdx)
            {
                if (data[i] < data[j])
                {
                    result[copy++] = data[i++];
                }
                else if (data[i] > data[j])
                {
                    result[copy++] = data[j++];
                }
            }

            while (i <= middleIdx)
                result[copy++] = data[i++];
            while (j <= endIdx)
                result[copy++] = data[j++];

            for (int k = endIdx; k >= startIdx; k--)
            {
                data[k] = result[--copy];
            }
        }
        
        //
        private static void swap(ref int num1 , ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
        ///
        private static int[] CopyByValue(int[] data1, int[] data2)
        {
            for(int i=0; i<data2.Length;i++)
            {
                data1[i] = data2[i];
            }
            return data1;
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
        protected int count = -1;
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
            get { return count; }
        }
        public bool IsEmpty
        {
            get { return count < 0 ? true : false; }
        }
        public bool IsFull
        {
            get { return count < (max - 1) ? false : true; }
        }
        // for test
        virtual public T[] Clone()
        {
            if (count < 0)
                return null;
            T[] data = new T[count + 1];
            for (int i = 0; i <= count; i++)
            {
                data[i] = this.data[i];
            }
            return data;
        }
    }
    // Circular Queue
    public class CheatingCircularQueue<T> : DataStructure<T>
    {
        int front = 0;
        int rear = -1;
        public CheatingCircularQueue(int size)
            : base(size)
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
                count++;
                rear = (rear + 1) % max;
                this.data[rear] = data;
               
            }
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Queue is empty");

            }
            else
            {
                T popdata = this.data[front];   //front 데이터를 가져옴
                front=(front+1) % max;
                count--;
                return popdata;
            }
        }
        public T[] Clone()
        {
            if (count < 0)
                return null;
            T[] data = new T[count + 1];
            int startIdx = front;
            for (int i = 0; i <= count; i++)
            {

                data[i] = this.data[startIdx];
                startIdx = (startIdx + 1) % max;
            }
            return data;
        }


    }

    // queue
    public class CheatingQueue<T> : DataStructure<T>
    {
        
        public CheatingQueue(int size)
            : base(size)
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
                count++;
                this.data[count] = data;
            }
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Queue is empty");
                
            }
            else
            {
                T popdata = this.data[0];   //맨첫번째 데이터을 pop
                ShiftQueue();
                count--;
                return popdata;
            }
        }
        private void ShiftQueue()
        {
            for(int i=0; i< count ; i++)
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
                count++;
                this.data[count] = data;
                top++;
            }
        }

        public T Pop()
        {
            if(count >-1)
            {
                T popdata = data[top];
                count--;
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
