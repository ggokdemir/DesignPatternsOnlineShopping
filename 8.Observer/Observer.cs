using System;
using System.Collections.Generic;
using System.Threading;

namespace OnlineShoppingCenter
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }

    public class NewProductSubject : ISubject
    {
        public int Discount { get; set; } = -0;

        private List<IObserver> _observers = new List<IObserver>();


        public void Attach(IObserver observer)
        {
            Console.WriteLine("A client attached to the subject.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("A client detached from the subject.");
        }

        public void Notify()
        {
            Console.WriteLine("Notifying clients...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

 
        public void DiscountOnTheNewProduct()
        {
            Console.WriteLine(" There is an important DISCOUNT! ");
            this.Discount = new Random().Next(10, 50);

            Thread.Sleep(10);

            Console.WriteLine("Subject: My Discount rate has just changed to: " + this.Discount);
            this.Notify();
        }
    }


    class Customer1 : IObserver
    {
        public void Update(ISubject subject)
        {            
            if ((subject as NewProductSubject).Discount > 30)
            {
                Console.WriteLine("Customer1: Reacted to the discount!.");
            }
        }
    }

    class Customer2 : IObserver
    {
        public void Update(ISubject subject)
        {
            if ( (subject as NewProductSubject).Discount >= 20)
            {
                Console.WriteLine("Customer2: Reacted to the discount!.");
            }
        }
    }

}