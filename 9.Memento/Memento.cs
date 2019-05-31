using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace OnlineShoppingCenter
{

    class Originator
    {

        private string _ShoppingCardID;

        public Originator(string ShoppingCardID)
        {
            this._ShoppingCardID = ShoppingCardID;
            Console.WriteLine("My initial ShoppingCardID is: " + ShoppingCardID);
        }

        public void CreateNewCardID()
        {
            Console.WriteLine("I'm creating a new shopping card with new ID.");
            this._ShoppingCardID = this.GenerateRandomString(30);
            Console.WriteLine($"My last ShoppingCardID has changed to: {_ShoppingCardID}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        public IShoppingCard Save()
        {
            return new ConcreteShoppingCard(this._ShoppingCardID);
        }

        // Restores the Originator's ShoppingCardID from a ShoppingCard object.
        public void Restore(IShoppingCard ShoppingCard)
        {
            if (!(ShoppingCard is ConcreteShoppingCard))
            {
                throw new Exception("Unknown ShoppingCard class " + ShoppingCard.ToString());
            }

            this._ShoppingCardID = ShoppingCard.GetShoppingCardID();
            Console.Write($"My ShoppingCardID has changed to: {_ShoppingCardID}");
        }
    }

    public interface IShoppingCard
    {
        string GetID();

        string GetShoppingCardID();

        DateTime GetDate();
    }

    class ConcreteShoppingCard : IShoppingCard
    {
        private string _ShoppingCardID;

        private DateTime _date;

        public ConcreteShoppingCard(string ShoppingCardID)
        {
            this._ShoppingCardID = ShoppingCardID;
            this._date = DateTime.Now;
        }


        public string GetShoppingCardID()
        {
            return this._ShoppingCardID;
        }
        

        public string GetID()
        {
            return $"{this._date} / ({this._ShoppingCardID.Substring(0, 9)})...";
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }

    class Caretaker
    {
        private List<IShoppingCard> savedShoppingCards = new List<IShoppingCard>();

        private Originator _originator = null;

        public Caretaker(Originator originator)
        {
            this._originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("Saving ShoppingCardID...");
            this.savedShoppingCards.Add(this._originator.Save());
        }

        public void Undo()
        {
            if (this.savedShoppingCards.Count == 0)
            {
                return;
            }

            var ShoppingCard = this.savedShoppingCards.Last();
            this.savedShoppingCards.Remove(ShoppingCard);

            Console.WriteLine("My old shopping card id: " + ShoppingCard.GetID());

            try
            {
                this._originator.Restore(ShoppingCard);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of ShoppingCards:");

            foreach (var ShoppingCard in this.savedShoppingCards)
            {
                Console.WriteLine(ShoppingCard.GetID());
            }
        }
    }
}