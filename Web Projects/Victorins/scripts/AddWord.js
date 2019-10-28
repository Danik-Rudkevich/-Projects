$( document ).ready(function() {
$("#btn").click(
function(){

  //Чистка span
  $("#dWordError").html("");
  $("#rWordError").html("");

  //запрос
  Send('frm', 'DBAdd.php');
  return false;
  }
);

});



function Send(ajax_form, url) {
$.ajax({
    url:     url, //url страницы (action_ajax_form.php)
    type:     "POST", //метод отправки
    dataType: "html", //формат данных
    data: $("#"+ajax_form).serialize(),  // Сеарилизуем объект
    success: function(response) { //Данные отправлены успешно
      result = $.parseJSON(response);
      if(result.length == 0)
      {
        alert("Слово добавленно!");
      }
      else
      {
          if(! (result['dWordError'] === undefined))
          {
              $("#dWordError").html(result['dWordError']);
          }

          if(! (result['rWordError'] === undefined))
          {
            $("#rWordError").html(result['rWordError']);
          }
      }
  },
  error: function(response) { // Данные не отправлены
      alert("Error");
  }
});
}
