using System;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInversionPrinciple
{
    //we should depend on abstractions , not hardcoded implementations
    public enum RelationShip
    {
        Parent,
        Child,
        Sibling
    }

    public class Person
    {
        public string Name { get; set; }
    }

    public interface IRelationShipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    // low level module
    public class RelationShips : IRelationShipBrowser
    {
        private List<(Person, RelationShip, Person)> relations = new List<(Person, RelationShip, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, RelationShip.Parent, child));
            relations.Add((child, RelationShip.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations.Where
                (
                    x => x.Item1.Name == "John" &&
                    x.Item2 == RelationShip.Parent
                ).Select(r => r.Item3);
        }

        //get rid of this 
        // public List<(Person, RelationShip, Person)> Relations => relations;
    }

    //high level module
    class Research
    {
        //public Research(RelationShips relationShips)
        //{
        //    // BAD IDEA TO ACCESS A REALLY LOW LEVEL (PRIVATE) PART OF LOW LEVEL MODULE
        //    // and we also can not really change the RelationShips class without breaking everything
        //    //var relations = relationShips.Relations;
        //    //foreach (var r in relations.Where
        //    //    (
        //    //        x => x.Item1.Name == "John" &&
        //    //        x.Item2 == RelationShip.Parent
        //    //    )) 
        //    //{
        //    //    Console.WriteLine($"John has a child called {r.Item3.Name}");
        //    //}
        //}

        public Research(IRelationShipBrowser browser)
        {
            //get it without dependancy on low level implementations 
            foreach(var p in browser.FindAllChildrenOf("John"))
                Console.WriteLine($"John has a child called {p.Name}");
        }

        static void Main(string[] args)
        {
            //do research
            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Chris" };
            var child2 = new Person { Name = "Marry" };

            var relationShips = new RelationShips();
            relationShips.AddParentAndChild(parent, child1);
            relationShips.AddParentAndChild(parent, child2);

            new Research(relationShips);
        }
    }
}
