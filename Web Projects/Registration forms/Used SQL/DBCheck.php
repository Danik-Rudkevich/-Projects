<?php
session_start();

		//Получаем данные
    $login = $_POST["login"];
    $password = $_POST["password"];

    //Проверяем данные
    $error = array();

      //Проверяем логин
      if($login == "")
      {
        $error = array_merge(array('login' => "Введите логин"),$error);
      }


      $_SESSION["login"] = $login;

      //Проверяем пароль
      if($password == "")
      {
        $error = array_merge(array('password' => "Введите пароль"),$error);
      }

		//Если ошибок не возникло проверяем логин и пароль
		if(empty( $error ))
		{
      $my_sqli = new mysqli("localhost","user","123","users");
      $my_sqli->query("SET NAMES 'utf8' ");
      $result =$my_sqli->query("SELECT `password` FROM `accounts` WHERE `login` = '$login'");

      $my_sqli->close();

      $result = $result->fetch_assoc();

      if(count($result)>0)
      {
        if($result['password'] !=  md5($password))
        {
            $error = array_merge(array('password' => "Не верный пароль!"),$error);
        }
      }
      else
      {
        $error = array_merge(array('login' => "Логин не найден!!"),$error);
      }

    }

    if(empty( $error ))
    {
      //создаем куки
        setcookie("login", $login, 2147483647);

        setcookie("password", md5($password), 2147483647);
    }
    else if(isset($_COOKIE['login']) || $_COOKIE['password'])
    {
      if(isset($_COOKIE['login']))
      {
        unset($_COOKIE['login']);
      }
      if(isset($_COOKIE['password']))
      {
        unset($_COOKIE['password']);
      }
    }

		/////////////////////////////////////////////////////////////////////

    // Переводим массив в JSON
    echo json_encode($error);

?>
