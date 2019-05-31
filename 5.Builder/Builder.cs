using System;
using System.Collections.Generic;

namespace OnlineShoppingCenter
{

    public interface IBuilder
    {
        void Discount10per();
        
        void Discount20per();
        
        void Discount50per();
    }
    

    public class ConcreteBuilder : IBuilder
    {
        private Pmembership _pmembership = new Pmembership();
        
        public ConcreteBuilder()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._pmembership = new Pmembership();
        }
        
        public void Discount10per()
        {
            this._pmembership.Add("%10 discount on every second product");
        }
        
        public void Discount20per()
        {
            this._pmembership.Add("%20 discount on every third product");
        }
        
        public void Discount50per()
        {
            this._pmembership.Add("%50 discount on every fourth product");
        }

        public Pmembership GetPmembership()
        {
            Pmembership result = this._pmembership;

            this.Reset();

            return result;
        }
    }
    
    public class Pmembership
    {
        private List<object> _parts = new List<object>();
        
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); // removing last ",c"

            return "Pmembership parts: " + str + "\n";
        }
    }
    
    public class Director
    {
        private IBuilder _builder;
        
        public IBuilder Builder
        {
            set { _builder = value; } 
        }
        
        public void buildMinimalViablePmembership()
        {
            this._builder.Discount10per();
        }
        
        public void buildFullFeaturedPmembership()
        {
            this._builder.Discount10per();
            this._builder.Discount20per();
            this._builder.Discount50per();
        }
    }

}