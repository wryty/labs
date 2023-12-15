<?php

$directory = __DIR__;
$pattern = '/^log\d+\..+$/';

$files = scandir($directory);

foreach ($files as $file) {
    if (preg_match($pattern, $file)) {
        echo $file . PHP_EOL;
    }
}

