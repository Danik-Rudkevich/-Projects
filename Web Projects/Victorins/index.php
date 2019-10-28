<?php
$my_sqli = new mysqli("localhost","user","123","wordsdb");
$my_sqli->query("SET NAMES 'utf8' ");
$result =$my_sqli->query("SELECT * FROM `words`");
$myrow = array();
while($row = $result->fetch_assoc())
{
  array_push($myrow, $row);
}

$my_sqli->close();
 ?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
	<title>Главная</title>
	<link rel="stylesheet" href="css/style.css" media="screen" type="text/css" />
	<link rel="stylesheet" href="css/indexStyle.css" media="screen" type="text/css" />
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
  <script src="scripts/script.js"></script>
</head>
<body>

    <div id="Game">
            <fieldset class="clearfix">
								<p>Переведи: <span id="Word"></span> </p>

                  <p id="first">

                  </p>

                  <p id="second">

                  </p>

                  <p id="thread">

                  </p>

                <noscript><p>Ваш браузер не поддерживает скрипты!</p></noscript>
								<script type="text/javascript">
									$(".clearfix").append('<p><button onclick="Go()">Добавить слово</button></p>');

								</script>
            </fieldset>
    </div>

    <script type="text/javascript">

      var WordArr = <?php echo json_encode($myrow); ?> ;
      var correctVariant;

      Restart();
    </script>
</body>
</html>
