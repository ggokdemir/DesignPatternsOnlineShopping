using System;

namespace OnlineShoppingCenter
{
    class AdapterProgram
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Other shopping sites interface is incompatible with the our site.");
            Console.WriteLine("But with adapter we can call users information.");

            Console.WriteLine(target.GetUserInformation());



        }
    }
}
