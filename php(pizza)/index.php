<?php

require_once __DIR__ . '/vendor/autoload.php';

use PizzaStore\NYStylePizzaStore;
use PizzaStore\ChicagoStylePizzaStore;


$nyStore = new NYStylePizzaStore();
$chicagoStore = new ChicagoStylePizzaStore();

$nyStore->orderPizza('pepperoni');
$chicagoStore->orderPizza('margherita');
