using LiskovSubstitutionPrinciple.Models;
using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        public static int Area(Rectangle rectangle) => rectangle.Width * rectangle.Height;
       
        //you should be able to substitute a base type for a subtype
        static void Main(string[] args)
        {
            Rectangle rc = new Rectangle(2, 3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            Square sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"sq has area {Area(sq)} ");

            //problems
            Rectangle sq1 = new Square();
            sq1.Width = 4;
            Console.WriteLine($"{sq1} has area {Area(sq1)} ");

        }
    }
}
