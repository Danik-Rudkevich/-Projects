<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
	<title>AddWord</title>
	<link rel="stylesheet" href="css/style.css" media="screen" type="text/css" />
	<link rel="stylesheet" href="css/AddWord.css" media="screen" type="text/css" />
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
	<script src="scripts/AddWord.js"></script>
</head>
<body>

    <div id="AddWord">
        <form id="frm">
            <fieldset class="clearfix">
								<p>Добавление слова</p>
								<span id="dWordError"></span>
								<p><input type="text" name="dWord" placeholder="Слово на немецком" value=""></p>
								<span id="rWordError"></span>
								<p><input type="text" name="rWord" placeholder="Слово на русском" value=""></p>
								<noscript><p>Ваш браузер не поддерживает скрипты!</p></noscript>
								<script type="text/javascript">
									$(".clearfix").append('<p><input id="btn" type="submit" name="btn" value="Добавить"></p>');
									//Потом доделать
								//	$(".clearfix").append('<p><label for="file-upload" class="custom-file-upload">Добавить файл</label><input id="file-upload" name"file" type="file"/></p>');
								</script>
            </fieldset>
        </form>
    </div>
</body>
</html>
