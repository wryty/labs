<?php

namespace PizzaStore;
use PizzaStore\Pizza;
class PepperoniPizza extends Pizza
{

    protected ?string $name = null;
    protected ?string $sause = null;
    protected ?array $toppings = null;

    public function __construct() 
    {
        $this->name = "Пепперони";
        $this->sause = "Соусы";
        $this->toppings = ["1","3"];
    }

    public function prepare(): void
    {
        echo "Началась готовка пиццы {$this->name}\n";
        echo "Добавлен соус {$this->sause}\n";
        echo "Добавлены топпинги: " . implode(', ', $this->toppings) . "\n";
    }
}
