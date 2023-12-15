<?php

namespace PizzaStore;

use _PHPStan_f73a165d5\Symfony\Component\Console\Exception\CommandNotFoundException;

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
        return match ($type) {
            'pepperoni' => new PepperoniPizza(),
            'margherita' => new MargheritaPizza(),
            default => throw new CommandNotFoundException("Pizza not found"),
        };
    }
}
