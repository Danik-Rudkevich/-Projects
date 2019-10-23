<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
	<title>Login</title>
	<link rel="stylesheet" href="css/style.css" media="screen" type="text/css" />
	<link rel="stylesheet" href="css/Login.css" media="screen" type="text/css" />
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
	<script src="scripts/login.js"></script>
</head>
<body>

	<div id="login">
			<form id="frm">
					<fieldset class="clearfix">
							<span id="loginError"></span>
							<p><span class="fontawesome-user"></span><input name="login" type="text" value="<?php echo $_SESSION["login"] ?>"  placeholder="Login"></p>
							<span id="passwordError"></span>
							<p><span class="fontawesome-lock"></span><input name="password" type="password"  value="<?php echo $_SESSION["password"] ?>"  placeholder="Password"></p>
							<noscript><p>Ваш браузер не поддерживает скрипты!</p></noscript>
							<script type="text/javascript">
								$(".clearfix").append('<p><input id="btn" type="submit" value="ВОЙТИ"></p>');
							</script>
					</fieldset>
			</form>
			<p>Нет аккаунта? &nbsp;&nbsp;<a href="registration.php">Регистрация</a><span class="fontawesome-arrow-right"></span></p>
	</div>

	<script type="text/javascript">
	if(!(getCookie("login") === undefined) && !(getCookie("password") === undefined))
	{
			$("#login").hide();
			$("body").append('<div id="Hello"><p>Hello '+ getCookie("login") +'</p></div>');
	}
	</script>
</body>
</html>
