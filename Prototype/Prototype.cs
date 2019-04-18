public class CloneFactory
{
    public Customer getClone(Customer customerSample){
        return customerSample.makeCopy();
    }
}

public interface ICustomer : Clonable
{
    public Customer makeCopy();
}

public class Customer : ICustomer{

    public Customer(){
        Console.WriteLine("Customer is made");
    }
    public ICustomer makeCopy(){
        Console.WriteLine("Customer is being made");

        Customer customerObject = null;

        try{
            customerObject = (Customer) base.clone();
        } catch (CloneNotSupportedException e){
            e.printStackTrace();
        }
        return customerObject;
    }
}

public class TestCloning{
    public void Main(string[] args){
        CloneFactory customerMaker = new CloneFactory();

        Customer customer1 = new Customer();
        Customer cloneCustomer1 = (Customer) customerMaker.getClone(customer1);
        Console.WriteLine(customer1);
        Console.WriteLine(cloneCustomer1);
    }
}
