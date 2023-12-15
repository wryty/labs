<?php

namespace UserService;

class UserService
{
    public static function sortByUsername(array $users, bool $ascending = true): array
    {
        usort($users, function (User $a, User $b) use ($ascending) {

            return $ascending ?
                strcmp($a->getUsername(), $b->getUsername()) : strcmp($b->getUsername(), $a->getUsername());
        });
        return $users;
    }

    public static function sortByBirthday(array $users, bool $ascending = true): array
    {
        usort($users, function (User $a, User $b) use ($ascending) {

            return $ascending ? $a->getBirthday() <=> $b->getBirthday() : $b->getBirthday() <=> $a->getBirthday();
        });
        return $users;
    }
}
