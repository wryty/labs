<?php
namespace PizzaStore;

abstract class Pizza
{
    protected ?string $name = null;
    protected ?string $sauce = null;
    protected ?array $toppings = null;

    abstract public function prepare(): void;

    public function cut(): void
    {
        echo "Данную пиццу нарезают по диагонали\n";
    }
}
