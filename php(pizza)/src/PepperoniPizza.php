<?php

class PepperoniPizza extends Pizza
{
    public function prepare(): void
    {
        echo "Началась готовка пиццы {$this->name}\n";
        echo "Добавлен соус {$this->sauce}\n";
        echo "Добавлены топпинги: " . implode(', ', $this->toppings) . "\n";
    }
}
