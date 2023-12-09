<?php

class NYStylePizzaStore extends PizzaStore
{
    public function orderPizza(string $type): void
    {
        $pizza = $this->createPizza($type);
        $pizza->prepare();
        $pizza->cut();
    }

    protected function createPizza(string $type): Pizza
    {
        switch ($type) {
            case 'pepperoni':
                return new PepperoniPizza();
            case 'margherita':
                return new MargheritaPizza();
            default:
                throw new InvalidArgumentException("Неизвестный тип пиццы: $type");
        }
    }
}
