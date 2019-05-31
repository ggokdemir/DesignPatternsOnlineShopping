using System;

namespace OnlineShoppingCenter
{
    class SingletonProgram
    {
        static void Main(string[] args)
        {
            SiteAdminSingleton s1 = SiteAdminSingleton.Instance(001);
            Console.WriteLine("System admin Id is: " + s1.getAdminId());
            SiteAdminSingleton s2 = SiteAdminSingleton.Instance(002);
            Console.WriteLine("System admin Id is: " + s2.getAdminId());

            if (s1 == s2)

            {

                Console.WriteLine("Objects are the same instance");

            }


        }
    }
}
