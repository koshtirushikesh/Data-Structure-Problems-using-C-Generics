﻿namespace LInkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.push(70);
            linkedListStack.push(30);
            linkedListStack.push(56);
            linkedListStack.Display();

            while (true)
            {
                linkedListStack.pop();
                linkedListStack.peak();
            }

            linkedListStack.Display();
        }
    }
}