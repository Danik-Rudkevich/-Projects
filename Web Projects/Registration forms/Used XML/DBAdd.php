<?php
session_start();

		//Получаем данные
    $login = $_POST["login"];
    $password = $_POST["password"];
		$c_password = $_POST["c_password"];
		$email = $_POST["email"];
    $name = $_POST["name"];

    $_SESSION["login"] = $login;
		$_SESSION["email"] = $email;
    $_SESSION["name"] = $name;

    //Проверяем данные
		$error = array();

		//Проверяем (unique) поля
		if ($login != "" && $email != "" && preg_match('/@/',$email)  && file_exists("test1.xml"))
		{
			$accounts = new SimpleXMLElement("test1.xml", NULL, TRUE);
			//Проверяем все аккаунты в БД
			foreach ($accounts->account as $acc)
			{
				if($login == $acc->login)
				{
					$error = array_merge(array('login' => "Логин занят!"),$error);
				}
				if($email == $acc->email)
				{
					$error = array_merge(array('email' => "Email занят!"),$error);
				}
			}
		}
		else
		{
			//Проверяем логин
			if($login == "")
			{
				$error = array_merge(array('login' => "Введите логин"),$error);
			}
			//Проверяем почту
			if($email == "")
			{
				$error = array_merge(array('email' => "Введите почту"),$error);
			}

      if(!preg_match('/@/',$email) )
			{
				$error = array_merge(array('email' => "Введите корректную почту"),$error);
			}

		}

		//Проверяем пароль
		if($password == "")
		{
			$error = array_merge(array('password' => "Введите пароль"),$error);
		}
		else if($c_password == ""){
			$error = array_merge(array('c_password' => "Введите подтверждение пароля"),$error);
		}
		else {
			if($c_password != $password)
			{
				$error = array_merge(array('c_password' => "Пароли не совпадают!"),$error);
			}
		}

		//Проверяем имя
		if($name == "")
		{
				$error = array_merge(array('name' => "Введите имя"),$error);
		}

		//Если ошибок не возникло добавляем данные в XML
		if(empty( $error ))
		{
			if(!file_exists("test1.xml")) //Если файла нет , то создаем
			{
				$dom = new DomDocument('1.0');

				//добавление - <account> в корень <accounts>

				$account = $dom->appendChild($dom->createElement('accounts'))->appendChild($dom->createElement('account'));
				//добавление всех полей в account
				$account->appendChild($dom->createElement('login'))->appendChild($dom->createTextNode($login));
				$account->appendChild($dom->createElement('password'))->appendChild($dom->createTextNode(md5($password)));
				$account->appendChild($dom->createElement('email'))->appendChild($dom->createTextNode($email));
				$account->appendChild($dom->createElement('name'))->appendChild($dom->createTextNode($name));

				//генерация xml
				$dom->formatOutput = true; // установка атрибута formatOutput
				                           // domDocument в значение true
				// save XML as string or file
				$dom->save('test1.xml'); // сохранение файла
			}
			else
			{
				$xml_doc = new DomDocument;

				$xml_doc->Load('test1.xml');

				$accounts = $xml_doc->getElementsByTagName('accounts')->item(0);

				$account = $accounts->appendChild($xml_doc->createElement('account'));

				$account->appendChild($xml_doc->createElement('login'))->appendChild($xml_doc->createTextNode($login));
				$account->appendChild($xml_doc->createElement('password'))->appendChild($xml_doc->createTextNode(md5($password)));
				$account->appendChild($xml_doc->createElement('email'))->appendChild($xml_doc->createTextNode($email));
				$account->appendChild($xml_doc->createElement('name'))->appendChild($xml_doc->createTextNode($name));

				$xml_doc->save("test1.xml");
			}

      //создаем куки
      	setcookie("login", $login, 2147483647);

      	setcookie("password", md5($password), 2147483647);
		}

		/////////////////////////////////////////////////////////////////////

    // Переводим массив в JSON
    echo json_encode($error);

?>
