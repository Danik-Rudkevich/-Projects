$( document ).ready(function() {
$("#btn").click(
function(){
  //Чистка span
  $("#c_passwordError").html("");
  $("#loginError").html("");
  $("#passwordError").html("");
  $("#emailError").html("");
  $("#nameError").html("");

  //запрос
  sendAjaxForm('frm', 'DBAdd.php');
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
        alert("Пользователь успешно добавлен");
        document.location.href = "index.php";
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

          if(! (result['c_password'] === undefined))
          {
            $("#c_passwordError").html(result['c_password']);
          }
      }
  },
  error: function(response) { // Данные не отправлены
      alert("Error");
  }
});
}
