<?php

namespace PizzaStore;

class MargheritaPizza extends Pizza
{
    protected ?string $name = null;
    protected ?string $sauce = null;
    protected ?array $toppings = null;
    public function __construct()
    {
        $this->name = "Маргарита";
        $this->sauce = "Соус пример для Маргариты";
        $this->toppings = ["топпинг пример 3","топпинг пример 4"];
    }
    public function prepare(): void
    {
        echo "Началась готовка пиццы $this->name\n";
        echo "Добавлен соус $this->sauce\n";
        echo "Добавлены топпинги: " . implode(', ', $this->toppings) . "\n";
    }

    public function cut(): void
    {
        echo "Данную пиццу нарезают обычным способом\n";
    }
}
