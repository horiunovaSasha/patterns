using System;
using Patterns.SingleReponsibility;

namespace Patterns
{
    class Program
    {
        //Single responsibility - single reason to change
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine("Hello World!");

            Console.WriteLine(j);
        }
    }
}