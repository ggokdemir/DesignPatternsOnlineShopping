using System;

namespace OnlineShoppingCenter
{
    class BuilderProgram
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic membership:");
            director.buildMinimalViablePmembership();
            Console.WriteLine(builder.GetPmembership().ListParts());

            Console.WriteLine("Gold full membership:");
            director.buildFullFeaturedPmembership();
            Console.WriteLine(builder.GetPmembership().ListParts());
            
        }
    }
}
