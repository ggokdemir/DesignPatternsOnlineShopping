using System;


namespace OnlineShoppingCenter
{


    class PatternContext
    {

        private IPatternStrategy _strategy;

        public PatternContext(IPatternStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IPatternStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {

        }
    }

    public interface IPatternStrategy
    {




    }

    public class SingletonPatternStrategy : IPatternStrategy
    {
        public SingletonPatternStrategy()
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
    public class FactoryPatternStrategy : IPatternStrategy
    {
        public FactoryPatternStrategy()
        {
            Console.WriteLine("App: Launched with the WebBrowserCreator.");
            WebBrowserCreator webCreator = new WebBrowserCreator();
            Console.WriteLine("Client: I'm not aware of the creator's class," + "but it still works.\n" + webCreator.PlatformInfo());
            Console.WriteLine("");
            Console.WriteLine("App: Launched with the MobileAppCretor.");
            MobileAppCretor mobileCreator = new MobileAppCretor();
            Console.WriteLine("Client: I'm not aware of the creator's class," + "but it still works.\n" + mobileCreator.PlatformInfo());
        }
    }
    public class PrototypePatternStrategy : IPatternStrategy
    {
        public PrototypePatternStrategy()
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
    public class ObjectPoolPatternStrategy : IPatternStrategy
    {
        public ObjectPoolPatternStrategy()
        {
            CallCenter cs = new CallCenter();
            CallCenterEmployee myEmp1 = cs.GetCallCenterEmployee();
            Console.WriteLine("First employee");
            CallCenterEmployee myEmp2 = cs.GetCallCenterEmployee();
            Console.WriteLine("Second employee");
        }
    }
    public class BuilderPatternStrategy : IPatternStrategy
    {

        public BuilderPatternStrategy()
        {

            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Builder = builder;

            Console.WriteLine("Standard basic membership:");
            director.buildMinimalViablePmembership();
            Console.WriteLine(builder.GetPmembership().ListParts());

            Console.WriteLine("Gold full membership:");
            director.buildFullFeaturedPmembership();
            Console.WriteLine(builder.GetPmembership().ListParts());

        }

    }
    public class AbstractFactoryPatternStrategy : IPatternStrategy
    {

        public AbstractFactoryPatternStrategy()
        {

            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the first factory type...");
            ClientMethod(new GamingFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type...");
            ClientMethod(new WorkstationFactory());


            void ClientMethod(IAbstractFactory factory)
            {
                var productA = factory.DesktopPC();
                var productB = factory.NotebookPC();

                Console.WriteLine(productB.SetConfigurationsNotebookPC());
    
            }


        }
    }
    public class IteratorPatternStrategy : IPatternStrategy { 

        public IteratorPatternStrategy(){

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
    public class ObserverPatternStrategy : IPatternStrategy { 

        public ObserverPatternStrategy(){
            
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
    public class MementoPatternStrategy : IPatternStrategy {
        public MementoPatternStrategy(){
                       
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
    public class CommandPatternStrategy : IPatternStrategy {
        public CommandPatternStrategy(){
          
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new TotalCost(100));
            InfoReceiver receiver = new InfoReceiver();
            invoker.CheckUserInfo();
            invoker.SetOnFinish(new PurchaseInfo(receiver, "John Doe", "454687631"));

        }
     }
    public class AdapterPatternStrategy : IPatternStrategy {

        public AdapterPatternStrategy(){
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Other shopping sites interface is incompatible with the our site.");
            Console.WriteLine("But with adapter we can call users information.");

            Console.WriteLine(target.GetUserInformation());
        }

     }


}