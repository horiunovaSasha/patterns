using System;

namespace SingleResponsibility
{
    class Program
    {
        //Single responsibility - single reason to change
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j);
            
            var fileManager = new FileManager();
            var fileName = @"d:\journal.txt";
            fileManager.SaveToFile(j,fileName, true);
        }
    }
}