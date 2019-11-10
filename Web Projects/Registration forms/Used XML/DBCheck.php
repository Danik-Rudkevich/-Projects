<?php
session_start();

		//Получаем данные
    $login = $_POST["login"];
    $password = $_POST["password"];

    $_SESSION["login"] = $login;

    //Проверяем данные
		$error = array();

			//Проверяем логин
			if($login == "")
			{
				$error = array_merge(array('login' => "Введите логин"),$error);
			}

		//Проверяем пароль
		if($password == "")
		{
			$error = array_merge(array('password' => "Введите пароль"),$error);
		}


		//Если ошибок не возникло проверяем логин и пароль
		if(empty( $error ))
		{
			if(!file_exists("test1.xml")) //Если файла нет , то говорим об этом
			{
					$error = array_merge(array('login' => "БД нет , зарегистрируйте первого пользователя!"),$error);
			}
			else
			{
        $accounts = new SimpleXMLElement("test1.xml", NULL, TRUE);

        $loginAccept = false;

        //Проверяем все аккаунты в БД
        foreach ($accounts->account as $acc)
        {
          if($login == $acc->login)
          {
            if(md5($password )!= $acc->password)
            {
              $error = array_merge(array('password' => "Не верный пароль!"),$error);
            }
            $loginAccept = true;
            break;
          }
        }

        if(!$loginAccept)
        {
          $error = array_merge(array('login' => "Логин не найден!"),$error);
        }

        if($loginAccept && empty( $error ) )
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
		}

    }

		/////////////////////////////////////////////////////////////////////

    // Переводим массив в JSON
    echo json_encode($error);

?>
