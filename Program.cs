using System;

namespace OnlineShoppingCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            int val;
            Console.Write("Enter design pattern scenario code number: ");
            val = Convert.ToInt32(Console.ReadLine());

            switch (val)
            {
                case 1:
                    PatternContext contextSingletonPatternStrategy = new PatternContext(new SingletonPatternStrategy());
                    break;
                case 2:
                    PatternContext contextFactoryPatternStrategy = new PatternContext(new FactoryPatternStrategy());
                    break;
                case 3:
                    PatternContext contextPrototypePatternStrategy = new PatternContext(new PrototypePatternStrategy());
                    break;
                case 4:
                    PatternContext contextObjectPoolPatternStrategy = new PatternContext(new ObjectPoolPatternStrategy());
                    break;
                case 5:
                    PatternContext contextBuilderPatternStrategy = new PatternContext(new BuilderPatternStrategy());
                    break;
                case 6:
                    PatternContext contextAbstractFactoryPatternStrategy = new PatternContext(new AbstractFactoryPatternStrategy());
                    break;
                case 7:
                    PatternContext contextIteratorPatternStrategy = new PatternContext(new IteratorPatternStrategy());
                    break;
                case 8:
                    PatternContext contextObserverPatternStrategy = new PatternContext(new ObserverPatternStrategy());
                    break;
                case 9:
                    PatternContext contextMementoPatternStrategy = new PatternContext(new MementoPatternStrategy());
                    break;
                case 10:
                    PatternContext contextCommandPatternStrategy = new PatternContext(new CommandPatternStrategy());
                    break;
                case 11:
                    PatternContext contextAdapterPatternStrategy = new PatternContext(new AdapterPatternStrategy());
                    break;
                default:
                    Console.WriteLine("The number is unknown.");
                    break;

            }
        }
    }
}
