namespace gurkangokdemir
{
    public class Memento
    {
        private string shoppingCart;
        public Memento(string shoppingCart) { shoppingCart = saveShoppingCart; }

        public string getSavedShoppingCart() { return shoppingCart; }

    }

    public class Orginator
    {
        private string shoppingCart;

        public void Set(string newShoppingCart)
        {
            Console.WriteLine("Current shopping info :" + newShoppingCart + " from Orginator");
            shoppingCart = newShoppingCart;

        }

        public Memento StoreInMemento()
        {
            Console.WriteLine("Saving to Memento from Orginator.");
            return new Memento(shoppingCart);
        }

        public string RestoreFromMemento(Memento memento)
        {
            shoppingCart = memento.getSavedShoppingCart();
            Console.WriteLine("Previous shopping info :" + shoppingCart + "saved in Memento from Orginator ");
            return shoppingCart;
        }
    }

    public class CareTaker
    {
        List<Memento> savedShoppingCarts = new List<Memento>();
        public void addMemento(Memento memento) { savedShoppingCarts.addMemento(memento); }
        public Memento getMemento(int index) { return savedShoppingCarts[index]; }

    }

    class TestMemento

    {

        public static void Main()

        {
            CareTaker careTaker = new CareTaker();
            Orginator orginator = new Orginator();

            string shoppingCart = "Coke: 20 \n Bread: 10 \n Soap: 15";

            orginator.Set(shoppingCart);
            careTaker.addMemento(orginator.StoreInMemento());

            string restoredShoppingCart;
            restoredShoppingCart = orginator.RestoreFromMemento(careTaker.getMemento(shoppingCart));

            Console.WriteLine("Your shopping cart: " + restoredShoppingCart);
            
        }
    }
}
