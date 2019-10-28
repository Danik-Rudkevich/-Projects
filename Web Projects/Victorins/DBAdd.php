<?php

$dWord = $_POST["dWord"];
$rWord = $_POST["rWord"];

//Проверяем данные
$error = array();

if($dWord == "" )
{
  $error = array_merge(array('dWordError' => "Введите слово на немецком"),$error);
}

if($rWord == "")
{
  $error = array_merge(array('rWordError' => "Введите слово на русском"),$error);
}

//если ошибок не найденно
if(empty( $error ))
{
  //Подключаемся к БД
  $my_sqli = new mysqli("localhost","user","123","wordsdb");
  $my_sqli->query("SET NAMES 'utf8' ");
  $result =$my_sqli->query("SELECT * FROM `words`");
  $myrow = array();

  while($row = $result->fetch_assoc())
  {
    //Если в БД уже есть такая запись
    if($row['dWord'] == $dWord)
    {
      $error = array_merge(array('dWordError' => "Такое слово уже есть в БД"),$error);
      break;
    }
    if($row['rWord'] == $rWord)
    {
      $error = array_merge(array('rWordError' => "Такое слово уже есть в БД"),$error);
      break;
    }
  }

  //если ошибок не найденно
  if(empty( $error ))
  {
    $my_sqli->query("INSERT INTO `words`(`rWord`, `dWord`) VALUES ('".$rWord."','".$dWord."')");
  }

  //Закрываем БД
  $my_sqli->close();
}



// Переводим массив в JSON
    echo json_encode($error);
 ?>
