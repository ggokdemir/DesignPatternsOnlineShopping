namespace gurkangokdemir
{
    interface IVisitor
    {
        public double Visit(GoldCustomer goldCustItem);
        public double Visit(StandardCustomer standardCustItem);
        public double Visit(NewCustomer newCustItem);
    }

    interface IVisitable
    {
        public double Accept(IVisitor visitor);
    }

    class DiscountVisitor : IVisitor
    {
        public DiscountVisitor()
        {

        }

        public double Visit(GoldCustomer goldCustItem)
        {
            Console.WriteLine("GoldCustomer's total cost including discount.");
            return goldCustItem.GetTotalCost() - (goldCustItem.GetTotalCost() * 30);
        }
        public double Visit(StandardCustomer standartCustItem)
        {
            Console.WriteLine("StandartCustomer's total cost including discount.");
            return standardCustItem.GetTotalCost() - (standardCustItem.GetTotalCost() * 10);
        }
        public double Visit(NewCustomer newCustItem)
        {
            Console.WriteLine("NewCustomer's total cost including discount.");
            return newCustItem.GetTotalCost() - (newCustItem.GetTotalCost() * 20);
        }
    }

    class BlackFridayDiscountVisitor : IVisitor
    {
        public BlackFridayDiscountVisitor()
        {

        }

        public double Visit(GoldCustomer goldCustItem)
        {
            Console.WriteLine("GoldCustomer's total cost including BlackFriday discount.");
            return goldCustItem.GetTotalCost() - (goldCustItem.GetTotalCost() * 50);
        }
        public double Visit(StandardCustomer standartCustItem)
        {
            Console.WriteLine("StandartCustomer's total cost including BlackFriday discount.");
            return standardCustItem.GetTotalCost() - (standardCustItem.GetTotalCost() * 25);
        }
        public double Visit(NewCustomer newCustItem)
        {
            Console.WriteLine("NewCustomer's total cost including BlackFriday discount.");
            return newCustItem.GetTotalCost() - (newCustItem.GetTotalCost() * 35);
        }
    }


    class GoldCustomer : IVisitable
    {
        private double price;

        GoldCustomer(double price)
        {
            this.price = price;
        }

        public double GetTotalCost()
        {
            return this.price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    class StandardCustomer : IVisitable
    {
        private double price;

        StandardCustomer(double price)
        {
            this.price = price;
        }

        public double GetTotalCost()
        {
            return this.price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    class NewCustomer : IVisitable
    {
        private double price;

        NewCustomer(double price)
        {
            this.price = price;
        }

        public double GetTotalCost()
        {
            return this.price;
        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }

    class VisitorPattern

    {

        public static void Main()

        {

            DiscountVisitor discountVisitor = new DiscountVisitor();
            BlackFridayDiscountVisitor blackFridayDiscountVisitor = new BlackFridayDiscountVisitor();

            GoldCustomer goldCustItem1 = new GoldCustomer(120.00);
            StandardCustomer standardCustItem1 = new StandardCustomer(120.00);
            NewCustomer newCustItem1 = new NewCustomer(120.00);

            Console.WriteLine(goldCustItem1.Accept(discountVisitor));
            Console.WriteLine(standardCustItem1.Accept(discountVisitor));
            Console.WriteLine(newCustItem1.Accept(discountVisitor));

            Console.WriteLine(goldCustItem1.Accept(blackFridayDiscountVisitor));
            Console.WriteLine(standardCustItem1.Accept(blackFridayDiscountVisitor));
            Console.WriteLine(newCustItem1.Accept(blackFridayDiscountVisitor));

        }
    }

}

