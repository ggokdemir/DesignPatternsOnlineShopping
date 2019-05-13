@startuml
class CustomerFactoryPatternDemo{
+main(): void
}

class CustomerProducer{
+getFactory(): CustomerFactory
}

abstract class CustomerFactory{
+getCustomerInfo(): Info
}

abstract class InfoFactory{
+getCustomerInfo(): Info
}

abstract class CustomerInfo{
+getName(): String
+getSurnam(): String
+getAdress(): String
+getId(): String
+getCardId() : String
+getPassword() : String 
}

class OldCustomer{
+getName(): String
+getSurnam(): String
+getAdress(): String
+getId(): String
+getCardId() : String
+getPassword() : String 
}

class NewCustomer{
+getName(): String
+getSurnam(): String
+getAdress(): String
+getId(): String
+getCardId() : String
+getPassword() : String 
}

class GoldCustomer{
+getName(): String
+getSurnam(): String
+getAdress(): String
+getId(): String
+getCardId() : String
+getPassword() : String 
}

CustomerFactory <-- CustomerProducer : uses
CustomerProducer <-- CustomerFactoryPatternDemo : uses
CustomerFactory <-- InfoFactory : extends
CustomerInfo <-- InfoFactory : creates
CustomerInfo <-- OldCustomer : implements
CustomerInfo <-- NewCustomer : implements
CustomerInfo <-- GoldCustomer : implements
@enduml
