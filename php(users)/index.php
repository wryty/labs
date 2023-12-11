<?php
require_once __DIR__ . '/vendor/autoload.php';
use UserService\UserService;
use UserService\User;


$users = [
    new User('user3', 'password3', new DateTime('1990-03-15')),
    new User('user1', 'password1', new DateTime('1985-12-10')),
    new User('user2', 'password2', new DateTime('1995-05-20')),
];

echo "Сортировка по username (по возрастанию):\n";
print_r(UserService::sortByUsername($users));

echo "\nСортировка по birthday (по убыванию):\n";
print_r(UserService::sortByBirthday($users, false));
?>

