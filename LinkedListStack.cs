using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInkedListDemo
{
    internal class LinkedListStack
    {
        private Node top;
        public LinkedListStack() 
        {
            this.top = null;
        }

        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null) 
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        internal void Display() 
        {
            Node temp = this.top;
            while(temp != null) 
            {
                Console.WriteLine(temp.data+ " ");
                temp = temp.next;
                
            }
        }

        internal void peak() 
        {
            if (this.top==null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("{0} is top of the stack ", this.top.data);
        }

        internal void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            this.top = this.top.next;
        }

        internal void IsEmpty()
        {
            while(this.top != null)
            {
                peak();
                pop();
            }
        }
    }
}
