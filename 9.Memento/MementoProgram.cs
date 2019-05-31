using System;

namespace OnlineShoppingCenter
{
    class MementoProgram
    {
        static void Main(string[] args)
        {

            Originator originator = new Originator("SOMEID123435434");
            Caretaker caretaker = new Caretaker(originator);

            caretaker.Backup();
            originator.CreateNewCardID();

            caretaker.Backup();
            originator.CreateNewCardID();

            caretaker.Backup();
            originator.CreateNewCardID();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine(" Now, let's rollback to old ID\n");
            caretaker.Undo();

            Console.WriteLine(" Once more!\n");
            caretaker.Undo();

            Console.WriteLine();


        }
    }
}
