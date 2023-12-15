<?php

namespace PizzaStore;

class PepperoniPizza extends Pizza
{
    protected string $name;
    protected string $sauce;
    protected array $toppings;

    public function __construct()
    {
        $this->name = "Пепперони";
        $this->sauce = "Соус пример для Пепперони";
        $this->toppings = ["топпинг пример 1","топпинг пример 2"];
    }

    public function prepare(): void
    {
        echo "Началась готовка пиццы $this->name\n";
        echo "Добавлен соус $this->sauce\n";
        echo "Добавлены топпинги: " . implode(', ', $this->toppings) . "\n";
    }
}
