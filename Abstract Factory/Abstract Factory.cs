@startuml
class CustomerDemo{
+main(): void
}

class CustomerProducer{
+getFactory(): CustomerFactory
}

class CustomerFactory{
+getCustomerInfo():Info
}

class InfoFactory{
+getCustomerInfo(): Info
}

class CustomerInfo{
+getName(): String
+getSurnam(): String
+getAdress(): String
+getId(): String
+getCardId() : String
+getPassword() : String 
}

CustomerFactory <-- CustomerProducer :uses
CustomerProducer <-- CustomerDemo :uses
@enduml
