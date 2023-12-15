<?php

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $login = isset($_POST['login']) ? $_POST['login'] : '';
    $password = isset($_POST['password']) ? $_POST['password'] : '';

    $usersData = json_decode(file_get_contents('users.json'), true);

    $loggedInUser = null;
    foreach ($usersData as $user) {
        if ($user['login'] === $login && $user['password'] === $password) {
            $loggedInUser = $user;
            break;
        }
    }

    if ($loggedInUser) {
        echo 'Добро пожаловать, ' . $loggedInUser['login'] . '!';
    } else {
        echo 'Проверьте ваши данные.';
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login Page</title>
</head>
<body>
<h2>Login</h2>
<form method="post" action="">
    <label for="login">Login:</label>
    <label>
        <input type="text" name="login" required>
    </label><br>
    <label for="password">Password:</label>
    <label>
        <input type="password" name="password" required>
    </label><br>
    <input type="submit" value="Login">
</form>
</body>
</html>