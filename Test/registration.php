<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
	<title>Registration</title>
	<link rel="stylesheet" href="css/style.css" media="screen" type="text/css" />
	<link rel="stylesheet" href="css/Registration.css" media="screen" type="text/css" />
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
	<script src="scripts/reg.js"></script>
</head>
<body>

    <div id="Registration">
        <form id="frm">
            <fieldset class="clearfix">
								<p>Регистрация</p>
								<span id="loginError"></span>
								<p><input type="text" name="login" placeholder="Login" value="<?php echo $_SESSION["login"] ?>"></p>
								<span id="passwordError"></span>
								<p><input type="password" name="password" placeholder="Password"></p> <!-- Пароли обычно в формах регистрации каждый раз заново вводят. Думаю это из-за опасности кражи из сессии незакодированного пароля , поэтому пароль в сессию не ложил -->
								<span id="c_passwordError"></span>
								<p><input type="password" name="c_password" placeholder="Confirm_password"></p>
								<span id="emailError"></span>
								<p><input type="text" name="email" placeholder="Email" value="<?php echo $_SESSION["email"] ?>"></p>
								<span id="nameError"></span>
								<p><input type="text" name="name" placeholder="Name" value="<?php echo  $_SESSION["name"] ?>"></p>
								<noscript><p>Ваш браузер не поддерживает скрипты!</p></noscript>
								<script type="text/javascript">
									$(".clearfix").append('<p><input id="btn" type="submit" name="btn" onclick="Send()" value="Зарегистрироваться"></p>');
								</script>
            </fieldset>
        </form>
    </div>
</body>
</html>
