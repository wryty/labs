<?php

namespace PizzaStore;

abstract class PizzaStore
{
    abstract public function orderPizza(string $type): void;

    abstract protected function createPizza(string $type): Pizza;
}
