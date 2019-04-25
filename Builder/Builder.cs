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
+packing(): Packing
}

CartBuilder <-- CartBuilderPatternDemo: asks
@enduml
