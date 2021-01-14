using OpenClosedPrinciple.Filters;
using OpenClosedPrinciple.Specifications;
using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        // The class should be opened for extension but should be closed for modification (inerfaces and inheritance)
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

          // old one
            var pf = new ProductFilter();
            Console.WriteLine("Green products old :");
            foreach (var p in pf.FilterByColor(products, Color.Green)) 
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            // new one 
            //created ISpecification(condidion) and IFilter(checking condition)
            var bf = new BetterFilter();
            Console.WriteLine("Green products new :");

            foreach (var item in bf.Filter(products, new ColorSpecification(Color.Green)))
                Console.WriteLine($" - {item.Name} is green");

            //using combined specification
            Console.WriteLine("Large blue items: ");
            foreach (var item in bf.Filter(products, new AndSpecification<Product>(
                new ColorSpecification(Color.Blue),
                new SizeSpecification(Size.Large)
                )))
            {
                Console.WriteLine($" - {item.Name} is large and blue");
            }

        }
    }
}
