using System;

namespace OnlineShoppingCenter{    
    public class Client
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;
        public CardInfo CardInfo;

        public Client ShallowCopy()
        {
            return (Client) this.MemberwiseClone();
        }

        public Client DeepCopy()
        {
            Client clone = (Client) this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }
    }

    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

    public class CardInfo
    {
        public int CardNumber;

        public CardInfo(int cardNumber)
        {
            this.CardNumber = cardNumber;
        }
    }

}