using System;

namespace OnlineShoppingCenter
{

    public interface ITarget
    {
        string GetUserInformation();
    }


    class Adaptee
    {
        public string AnotherShoppingSite()
        {
            return "Another shopping site.";
        }
    }


    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetUserInformation()
        {
            return $"This user information coming from'{this._adaptee.AnotherShoppingSite()}'";
        }
    }
}