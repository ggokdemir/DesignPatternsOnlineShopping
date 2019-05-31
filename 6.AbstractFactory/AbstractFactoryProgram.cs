using System;

namespace OnlineShoppingCenter
{
    class AbstractFactoryProgram
    {
        static void Main(string[] args)
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
