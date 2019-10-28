function shuffle(array) {
  var currentIndex = array.length, temporaryValue, randomIndex;

  while (0 !== currentIndex) {

    randomIndex = Math.floor(Math.random() * currentIndex);
    currentIndex -= 1;

    temporaryValue = array[currentIndex];
    array[currentIndex] = array[randomIndex];
    array[randomIndex] = temporaryValue;
  }

  return array;
}

function Restart()
{
  var rnd = Math.floor(Math.random() * Math.floor(20));
  var rndToInsert;


  if(rnd%2==0)
  {
     rnd = Math.floor(Math.random() * Math.floor(WordArr.length));//выбираем случайное слово

     $('#Word').html(WordArr[rnd]['dWord']);

     correctVariant = WordArr[rnd]['rWord'];

     var variation = [rnd];

     for (var i = 0; i < 2; i++)
     {
       do
       {
         rndToInsert = Math.floor(Math.random() * Math.floor(WordArr.length));
       } while (variation.indexOf( rndToInsert ) != -1);

       variation.push(rndToInsert);
     }

    variation = shuffle(variation);


    $('#first').html(WordArr[variation[0]]['rWord']);
    $('#second').html(WordArr[variation[1]]['rWord']);
    $('#thread').html(WordArr[variation[2]]['rWord']);

  }
  else
  {
    rnd = Math.floor(Math.random() * Math.floor(WordArr.length));//выбираем случайное слово

    $('#Word').html(WordArr[rnd]['rWord']);

    correctVariant = WordArr[rnd]['dWord'];

    var variation = [rnd];

    for (var i = 0; i < 2; i++)
    {
      do
      {
        rndToInsert = Math.floor(Math.random() * Math.floor(WordArr.length));
      } while (variation.indexOf( rndToInsert ) != -1);

      variation.push(rndToInsert);
    }


    variation = shuffle(variation);

    $('#first').html(WordArr[variation[0]]['dWord']);
    $('#second').html(WordArr[variation[1]]['dWord']);
    $('#thread').html(WordArr[variation[2]]['dWord']);

  }
}

function Check()
{
  if($("#first").html() == correctVariant)
  {
    $("#first").css("background-color","green");
  }
  else
  {
    $("#first").css("background-color","red");
  }
  if($("#second").html() == correctVariant)
  {
    $("#second").css("background-color","green");
  }
  else
  {
      $("#second").css("background-color","red");
  }
  if($("#thread").html() == correctVariant)
  {
    $("#thread").css("background-color","green");
  }
  else
  {
    $("#thread").css("background-color","red");
  }
}

function UnCheck() {

  $("#first").removeAttr('background-color');
  $("#second").removeAttr('background-color');
  $("#thread").removeAttr('background-color');
  $("#thread").css("background-color","");
  $("#second").css("background-color","");
  $("#first").css("background-color","");
}

$( document ).ready(function() {
$("#first").click(
function(){
  Check();
  let timerId = setTimeout(Restart(), 3000);
  UnCheck();
  clearTimeout(timerId);
  return false;
  }
);

$("#second").click(
function(){
  Check();
  let timerId = setTimeout(Restart(), 3000);
  UnCheck();
  clearTimeout(timerId);
  return false;
  }
);

$("#thread").click(
function(){
  Check();
  let timerId = setTimeout(Restart(), 3000);
  UnCheck();
  clearTimeout(timerId);
  return false;
  }
);

});

function Go()
{
  document.location.href="AddWord.php";
}
