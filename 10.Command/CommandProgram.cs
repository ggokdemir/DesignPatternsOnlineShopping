using System;

namespace OnlineShoppingCenter
{
    class CommandProgram
    {
        static void Main(string[] args)
        {

            Invoker invoker = new Invoker();
            invoker.SetOnStart(new TotalCost(100));
            InfoReceiver receiver = new InfoReceiver();
            invoker.CheckUserInfo();
            invoker.SetOnFinish(new PurchaseInfo(receiver, "John Doe", "454687631"));


        }
    }
}
