using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class LinkedListQueue
    {
        private Node front;
        private Node rear;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);

            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
        }

        public int Dequeue()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            int data = front.Data;
            front = front.Next;

            if (front == null)
            {
                rear = null;
            }

            return data;
        }

        public int Peek()
        {
            if (front == null)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}
