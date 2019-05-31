using System;

namespace OnlineShoppingCenter{

    abstract class Creator
    {

        public abstract IProduct FactoryMethod();


        public string PlatformInfo()
        {
            var product = FactoryMethod();

            var result = "You are using Online Shopping Center with : "
                + product.Operation();

            return result;
        }
    }


    class WebBrowserCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new WebBrowserProduct();
        }
    }

    class MobileAppCretor : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new MobileAppProduct();
        }
    }

    public interface IProduct
    {
        string Operation();
    }

    class WebBrowserProduct : IProduct
    {
        public string Operation()
        {
            return "Web Browser";
        }
    }
    class MobileAppProduct : IProduct
    {
        public string Operation()
        {
            return "Mobile App";
        }
    }

    
}