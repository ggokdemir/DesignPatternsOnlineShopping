namespace ObserverPattern
{
    public class Subject {
        
    private List<customerObserver> customerobservers = new ArrayList<customerObserver>();
    private int state;

    public int getState() {
        return state;
    }

    public void setState(int state) {
        this.state = state;
        notifyAllcustomerObservers();
    }

    public void attach(customerObserver customerobserver){
        customerobservers.add(customerobserver);		
    }

    public void notifyAllcustomerObservers(){
        for (customerObserver customerobserver : customerobservers) {
            customerobserver.update();
        }
    } 	
    }

    public abstract class customerObserver {
    protected Subject subject;
    public abstract void update();
    }

    public class Customer1 : customerObserver{

    public Customer1(Subject subject){
        this.subject = subject;
        this.subject.attach(this);
    }

    @Override
    public void update() {
        
    }
    }

    public class Customer2 : customerObserver{

    public Customer2(Subject subject){
        this.subject = subject;
        this.subject.attach(this);
    }

    @Override
    public void update() {
        
    }
    }

    public class Customer3 : customerObserver{

    public Customer3(Subject subject){
        this.subject = subject;
        this.subject.attach(this);
    }

    @Override
    public void update() {
        
    }
    }

    public class customerObserverPatternDemo {
    public static void main() {
        Subject subject = new Subject();

        new Customer3(subject);
        new Customer2(subject);
        new Customer1(subject);
    }
    }
}
