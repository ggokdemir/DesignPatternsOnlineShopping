using System;

namespace OnlineShoppingCenter
{
    public interface ICommand
    {
        void Execute();
    }

    class TotalCost : ICommand
    {
        private int _payload = 0;

        public TotalCost(int payload)
        {
            this._payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"TotalCost: ({this._payload})");
        }
    }

    class PurchaseInfo : ICommand
    {
        private InfoReceiver _infoReceiver;

        private string _userInfo;

        private string _cardInfo;

        public PurchaseInfo(InfoReceiver infoReceiver, string userInfo, string cardInfo)
        {
            this._infoReceiver = infoReceiver;
            this._userInfo = userInfo;
            this._cardInfo = cardInfo;
        }

        public void Execute()
        {
            Console.WriteLine("Purchase process about to begin.");
            this._infoReceiver.CheckUserInfo(this._userInfo);
            this._infoReceiver.CheckCardInfo(this._cardInfo);
        }
    }

    class InfoReceiver
    {
        public void CheckUserInfo(string userInfo)
        {
            Console.WriteLine($"Checking ({userInfo}.)");
        }

        public void CheckCardInfo(string cardInfo)
        {
            Console.WriteLine($"Checking ({cardInfo}.)");
        }
    }

    class Invoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }

        public void CheckUserInfo()
        {
            Console.WriteLine("Starting to puchase all items.");
            if (this._onStart is ICommand)
            {
                this._onStart.Execute();
            }
            
            Console.WriteLine("Purchase process...");
            
            Console.WriteLine("Purchase finished.");
            if (this._onFinish is ICommand)
            {
                this._onFinish.Execute();
            }
        }
    }
}