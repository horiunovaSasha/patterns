using System;

namespace InterfaceSegregationPrinciple
{
    public class Document{}


    //One interface for everything 
    public interface IMachine 
    {
        void Print(Document document);
        void Scan(Document document);
    }

    //Way out is to create a separate interfaces for that logic
    //IPrinter, IScanner

    public interface IPrinter 
    {
        void Print(Document document);
    }

    public interface IScanner 
    {
        void Scan(Document document);
    }

    public interface IMultyFunctionDevice : IPrinter, IScanner { }

    public class MultyFunctionalPrinter : IMultyFunctionDevice
    {

        public void Print(Document document)
        {
            // logic
        }

        public void Scan(Document document)
        {
            // logic
        }
    }

    // just implement IFilter, not whole IMashine
    public class OldFashionedPrinter : IPrinter
    {
        public void Print(Document document)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
