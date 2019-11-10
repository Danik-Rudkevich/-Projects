$( document ).ready(function() {
$("#btn").click(
function(){
  //Чистка span
  $("#loginError").html("");
  $("#passwordError").html("");

  //запрос
  sendAjaxForm('frm', 'DBCheck.php');
  return false;
  }
);
});

function sendAjaxForm(ajax_form, url) {
$.ajax({
    url:     url, //url страницы (action_ajax_form.php)
    type:     "POST", //метод отправки
    dataType: "html", //формат данных
    data: $("#"+ajax_form).serialize(),  // Сеарилизуем объект
    success: function(response) { //Данные отправлены успешно
      result = $.parseJSON(response);

      if(result.length == 0)
      {
        if(!(getCookie("login") === undefined) && !(getCookie("password") === undefined))
      	{
      			$("#login").hide();
      			$("body").append('<div id="Hello"><p>Hello '+ getCookie("login") +'</p></div>');
      	}
      }
      else
      {
          if(! (result['login'] === undefined))
          {
              $("#loginError").html(result['login']);
          }

          if(! (result['password'] === undefined))
          {
            $("#passwordError").html(result['password']);
          }
      }
  },
  error: function(response) { // Данные не отправлены
      alert("Error");
  }
});
}

function getCookie(name) //Получаем значения из куки
{
var value = "; " + document.cookie;
var parts = value.split("; " + name + "=");
if (parts.length == 2) return parts.pop().split(";").shift();
}
