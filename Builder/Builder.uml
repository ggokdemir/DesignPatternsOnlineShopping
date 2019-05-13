@startuml
class CartBuilderPatternDemo{
+main(): void
}

abstract class CartBuilder{
+takeTinyCart: Cart
+takeGoldCart: Cart
}

class Cart{
-items:ArrayList<item>
+addItem(Item item): void
+showItems(): void
+getCost(): float
}

class Item{
+name(): String
+price(): float
}

class Coke{
+price(): float
}
class Cake{
+price(): float
}

CartBuilder <-- CartBuilderPatternDemo: asks
Cart <-- CartBuilder : builds
Item <-- Cart : uses
Item <-- Coke : implements
Item <-- Cake : implements
@enduml
