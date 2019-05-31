using System;

namespace OnlineShoppingCenter
{
    class IteratorProgram
    {
        static void Main(string[] args)
        {

            var collection = new LuckyCustomers();
            collection.AddItem("Jane Doe");
            collection.AddItem("Jack Sparrow");
            collection.AddItem("Adam Smith");

            Console.WriteLine("Straight:");

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("\nReverse :");

            collection.ReverseDirection();

            foreach (var element in collection)
            {
                Console.WriteLine(element);
            }


        }
    }
}
