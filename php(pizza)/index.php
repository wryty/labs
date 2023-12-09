<?php

require_once __DIR__ . '/vendor/autoload.php';

use PizzaLibrary\NYStylePizzaStore;
use PizzaLibrary\ChicagoStylePizzaStore;

$nyStore = new NYStylePizzaStore();
$chicagoStore = new ChicagoStylePizzaStore();

$nyStore->orderPizza('pepperoni');
$chicagoStore->orderPizza('margherita');
