using System;

namespace OnlineShoppingCenter
{
    class ObserverProgram
    {
        static void Main(string[] args)
        {

            var subject = new NewProductSubject();
            var observerA = new Customer1();
            subject.Attach(observerA);

            var observerB = new Customer2();
            subject.Attach(observerB);

            subject.DiscountOnTheNewProduct();
            subject.DiscountOnTheNewProduct();

            subject.Detach(observerB);

            subject.DiscountOnTheNewProduct();


        }
    }
}
