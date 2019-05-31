using System;
using System.Collections;
using System.Collections.Generic;

namespace OnlineShoppingCenter
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract int Key();
        
        public abstract object Current();
        
        public abstract bool MoveNext();
        
        public abstract void Reset();
    }

    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }


    class AlphabeticalOrderIterator : Iterator
    {
        private LuckyCustomers _customerCollection;
        
        private int _customerPosition = -1;
        
        private bool _reverse = false;

        public AlphabeticalOrderIterator(LuckyCustomers customerCollection, bool reverse = false)
        {
            this._customerCollection = customerCollection;
            this._reverse = reverse;

            if (reverse)
            {
                this._customerPosition = customerCollection.getItems().Count;
            }
        }
        
        public override object Current()
        {
            return this._customerCollection.getItems()[_customerPosition];
        }

        public override int Key()
        {
            return this._customerPosition;
        }
        
        public override bool MoveNext()
        {
            int updatedPosition = this._customerPosition + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._customerCollection.getItems().Count)
            {
                this._customerPosition = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public override void Reset()
        {
            this._customerPosition = this._reverse ? this._customerCollection.getItems().Count - 1 : 0;
        }
    }

    class LuckyCustomers : IteratorAggregate
    {
        List<string> _customerCollection = new List<string>();
        
        bool _direction = false;
        
        public void ReverseDirection()
        {
            _direction = !_direction;
        }
        
        public List<string> getItems()
        {
            return _customerCollection;
        }
        
        public void AddItem(string customer)
        {
            this._customerCollection.Add(customer);
        }
        
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}