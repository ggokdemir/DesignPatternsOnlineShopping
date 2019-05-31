using System;

namespace OnlineShoppingCenter
{
    class PrototypeProgram
    {
        static void Main(string[] args)
        {

           Client p1 = new Client();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1977-01-01");
            p1.Name = "John Doe";
            p1.IdInfo = new IdInfo(666);
            p1.CardInfo = new CardInfo(123456789);

            // Client wants to add another account with different user name. (Same client with same card but different account name.)
            Client p2 = p1.ShallowCopy();
            // Client want to add totally new account. We copy clients current account then we change the details of the first account.
            Client p3 = p1.DeepCopy();

            // Display values of p1, p2 and p3.
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // Change the value of p1 properties and display the values of p1,
            // p2 and p3.
            p1.Age = 32;
            p1.BirthDate = Convert.ToDateTime("1900-01-01");
            p1.Name = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);

            void DisplayValues(Client p)
            {
                Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
                    p.Name, p.Age, p.BirthDate);
                Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
                Console.WriteLine("      CARDID#: {0:d}", p.CardInfo.CardNumber);
            }


        }
    }
}
