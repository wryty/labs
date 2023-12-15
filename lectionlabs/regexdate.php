<?php

$text = 'Приходи на ДР 09.08.2015! Будет весело! 12.13.2012';
$pattern = '/\b\d{2}\.\d{2}\.\d{4}\b/';

if (preg_match_all($pattern, $text, $matches)) {
    foreach ($matches[0] as $dateString) {
        try {
            $date = new DateTime($dateString);
            echo 'Найденная и правильная дата: ' . $date->format('d.m.Y') . PHP_EOL;
        } catch (Exception $e) {
            echo 'Найденная, но неверная дата: ' . $dateString . PHP_EOL;
        }
    }
} else {
    echo 'Даты не найдены.' . PHP_EOL;
}