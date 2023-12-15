<?php

namespace UserService;

use DateTime;

class User
{
    private string $username;
    private string $password;
    private DateTime $birthday;
    public function __construct(string $username, string $password, DateTime $birthday)
    {
        $this->username = $username;
        $this->password = $password;
        $this->birthday = $birthday;
    }

    public function getUsername(): string
    {
        return $this->username;
    }

    public function getBirthday(): DateTime
    {
        return $this->birthday;
    }
}
