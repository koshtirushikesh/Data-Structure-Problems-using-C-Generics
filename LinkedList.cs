﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LInkedListDemo
{
    public class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }temp.next = node;
            }
        }
        public void display()
        {
            Node temp = this.head;
            if(temp ==null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
