using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SO73752000.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SO73752000.Controllers
{

    //Main Operation in FIFO:
    //    Push: Adds an element to the top of the Stack.
    //    Pop: Removes and returns the top element from the Stack.
    //    Peek: Returns the top element without removing it.
    //    Count: The number of elements present in the Stack.

    class Program
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>();

            //  Add object to Stack
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);

            Console.WriteLine("Top element: " + numbers.Peek()); // 3

            //  Delete object to Stack
            Console.WriteLine("Popped element: " + numbers.Pop()); // 3
            Console.WriteLine("Top element after pop: " + numbers.Peek()); // 2

            Console.WriteLine("Count: " + numbers.Count); // 2
        }
    }
}

