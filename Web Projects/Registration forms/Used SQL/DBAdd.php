<?php
session_start();

		//Получаем данные
    $login = $_POST["login"];
    $password = $_POST["password"];
		$c_password = $_POST["c_password"];

    $_SESSION["login"] = $login;

    //Проверяем данные
		$error = array();

    //Проверяем пароль
		if($password == "")
		{
			$error = array_merge(array('password' => "Введите пароль"),$error);
		}
		else if($c_password == "")
    {
			$error = array_merge(array('c_password' => "Введите подтверждение пароля"),$error);
		}
		else
    {
			if($c_password != $password)
			{
				$error = array_merge(array('c_password' => "Пароли не совпадают!"),$error);
			}
      else
      {
        //Проверяем логин
        if($login == "")
        {
          $error = array_merge(array('login' => "Введите логин"),$error);
        }
        else
        {
          $my_sqli = new mysqli("localhost","user","123","users");
          $my_sqli->query("SET NAMES 'utf8' ");
          $result =$my_sqli->query("SELECT `login` FROM `accounts` WHERE `login` = '$login'");

          $result = $result->fetch_assoc();

          if(count($result)>0)
          {
            $error = array_merge(array('login' => "Логин занят!"),$error);
          }
          else
          {
            $password = md5($password);
            $my_sqli->query("INSERT INTO `accounts` (`login`, `password`) VALUES ('$login', '$password')");
          }

          $my_sqli->close();
        }
      }
		}

		/////////////////////////////////////////////////////////////////////

    // Переводим массив в JSON
    echo json_encode($error);

?>
