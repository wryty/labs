<?php
namespace PizzaStore;

abstract class Pizza
{
    protected string $name;
    protected string $sauce;
    protected array $toppings;

    abstract public function prepare(): void;

    public function cut(): void
    {
        echo "Данную пиццу нарезают по диагонали\n";
    }
}
