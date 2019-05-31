using System;

namespace OnlineShoppingCenter
{
    class FactoryProgram
    {
        static void Main(string[] args)
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
}
