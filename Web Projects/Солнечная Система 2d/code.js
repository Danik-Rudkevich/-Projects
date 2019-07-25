var ctx, w, h , canvas;
var stars = [];
var  N = 1000;

function statStars(x,y){
	this.x = x;
	this.y = y;
	
}

function rand(min,max){
	return Math.random() * (max - min) + min;
}

window.onload = function(){
	canvas = document.getElementById("canvas");
	w = canvas.width;
	h = canvas.height;
	ctx = canvas.getContext("2d");
	
	init();
}

function init(){
	for(var i = 0 ; i<N; ++i){
		stars[i] = new statStars(rand(0,w), rand(0,h));
	}
	
	setInterval(draw,33);
}

function draw(){
	ctx.clearRect(0,0,w,h); 
	ctx.fillStyle = "rgb(0,0,0)";
	ctx.fillRect(0,0,w,h);
	starsDraw();
	sun();
	planets();
	
}

function starsDraw(){
	ctx.fillStyle = "rgba(255,255,255,0.6)";
	
	for(var i = 0 ; i<N; ++i){
		ctx.beginPath();
		ctx.arc(stars[i].x,stars[i].y, 1, 0, Math.PI * 2, false);
		ctx.fill();
		ctx.closePath();
	}
}

var merc_x , merc_y, merc_v = 0;
var ven_x , ven_y, ven_v = 0;
var ear_x , ear_y, ear_v = 0;
var luna_x , luna_y, luna_v = 0;
var mars_x , mars_y, mars_v = 0;
var jupiter_x , jupiter_y, jupiter_v = 0;
var saturn_x , saturn_y, saturn_v = 0;
var saturn_kol_x , saturn_kol_y, saturn_kol_v = 0;
var yran_x , yran_y, yran_v = 0;
var neptun_x , neptun_y, neptun_v = 0;
function planets(){
	
	//Меркурий
	ctx.fillStyle = "rgb(112,128,144)"; 
	ctx.beginPath();
	ctx.arc(merc_x,merc_y,4,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	merc_v += 0.06;//скорость вращения , изменение позиции
	merc_x = w/2 + 100 * Math.sin(merc_v);
	merc_y = h/2 + 70 * Math.cos(merc_v);
	
	//Венера
	ctx.fillStyle = "rgb(181,116,52)";// Сочетание 3 основных цветов 
	ctx.beginPath();
	ctx.arc(ven_x,ven_y,5.5,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	ven_v += 0.03;//скорость вращения , изменение позиции
	ven_x = w/2 + 130 * Math.sin(ven_v);
	ven_y = h/2 + 100 * Math.cos(ven_v);
	
	//Земля
	ctx.fillStyle = "rgb(0,0,245)";// Сочетание 3 основных цветов 
	ctx.beginPath();
	ctx.arc(ear_x,ear_y,6,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	ear_v += 0.02;//скорость вращения , изменение позиции
	ear_x = w/2 + 160 * Math.sin(ear_v);
	ear_y = h/2 + 130 * Math.cos(ear_v);
	
	//Луна
	/*ctx.fillStyle = "rgb(255,250,250)";// Сочетание 3 основных цветов 
	ctx.beginPath();
	ctx.arc(luna_x,luna_y,2,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	luna_v += 0.03;
	luna_x = w/2 + 170 * Math.sin(ear_v);
	luna_y = h/2 + 140 * Math.cos(ear_v);
	*/
	
	//Луна
	ctx.fillStyle = "rgb(255,250,250)";// Сочетание 3 основных цветов 
	ctx.beginPath();
	ctx.arc(luna_x,luna_y,2,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	luna_v += 0.09;
	luna_x = ear_x + 10 * Math.sin(luna_v);
	luna_y = ear_y + 10 * Math.cos(luna_v);
	
	//Марс
	ctx.fillStyle = "rgb(245,64,33)";// Сочетание 3 основных цветов 
	ctx.beginPath();
	ctx.arc(mars_x,mars_y,6,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	mars_v += 0.025;//скорость вращения , изменение позиции
	mars_x = w/2 + 190 * Math.sin(mars_v);
	mars_y = h/2 + 160 * Math.cos(mars_v);
	
	//Юпитер
	ctx.fillStyle = "rgb(120,88,64)";// Сочетание 3 основных цветов 
	ctx.beginPath();
	ctx.arc(jupiter_x,jupiter_y,11,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	jupiter_v += 0.020;//скорость вращения , изменение позиции
	jupiter_x = w/2 + 240 * Math.sin(jupiter_v);
	jupiter_y = h/2 + 210 * Math.cos(jupiter_v);
	
	//Сатурн
	ctx.fillStyle = "rgb(128,128,128)";// Сочетание 3 основных цветов 
	ctx.beginPath();
	ctx.arc(saturn_x,saturn_y,10,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	saturn_v += 0.009;//скорость вращения , изменение позиции
	saturn_x = w/2 + 270 * Math.sin(saturn_v);
	saturn_y = h/2 + 240 * Math.cos(saturn_v);
	
	ctx.fillStyle = "rgba(125,127,125,0.5)";// кольца
	ctx.beginPath();
	ctx.arc(saturn_kol_x,saturn_kol_y,13,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	saturn_kol_v += 0.009;//скорость вращения , изменение позиции
	saturn_kol_x = w/2 + 270 * Math.sin(saturn_kol_v);
	saturn_kol_y = h/2 + 240 * Math.cos(saturn_kol_v);
	
	//Уран
	ctx.fillStyle = "rgb(135,206,250)";// Сочетание 3 основных цветов 
	ctx.beginPath();
	ctx.arc(yran_x,yran_y,7,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	yran_v += 0.007;//скорость вращения , изменение позиции
	yran_x = w/2 + 300 * Math.sin(yran_v);
	yran_y = h/2 + 270 * Math.cos(yran_v);
	
	//Нептун
	ctx.fillStyle = "rgb(0,130,230)";// Сочетание 3 основных цветов 
	ctx.beginPath();
	ctx.arc(neptun_x,neptun_y,7,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	neptun_v += 0.005;//скорость вращения , изменение позиции
	neptun_x = w/2 + 330 * Math.sin(neptun_v);
	neptun_y = h/2 + 300 * Math.cos(neptun_v);
	
}

function sun(){
	ctx.fillStyle = "rgba(255,255,255,0.9)"; 
	ctx.beginPath();
	ctx.arc(w/2,h/2,20,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	ctx.fillStyle = "rgba(250,204,0,0.7)"; // 0.8 прозрачность 204 цвет
	ctx.beginPath();
	ctx.arc(w/2,h/2,55,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	ctx.fillStyle = "rgba(250,204,0,0.6)"; 
	ctx.beginPath();
	ctx.arc(w/2,h/2,60,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	ctx.fillStyle = "rgba(250,204,0,0.5)"; 
	ctx.beginPath();
	ctx.arc(w/2,h/2,65,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	
	
	ctx.fillStyle = "rgb(250,0,0)"; // Эта штука задаёт цвет 
	ctx.beginPath();
	ctx.arc(w/2,h/2,25,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	ctx.fillStyle = "rgba(250,0,0,0.9)"; 
	ctx.beginPath();
	ctx.arc(w/2,h/2,30,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	ctx.fillStyle = "rgba(250,0,0,0.7)"; 
	ctx.beginPath();
	ctx.arc(w/2,h/2,35,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	ctx.fillStyle = "rgba(250,0,0,0.5)"; 
	ctx.beginPath();
	ctx.arc(w/2,h/2,40,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	ctx.fillStyle = "rgba(250,0,0,0.3)"; 
	ctx.beginPath();
	ctx.arc(w/2,h/2,45,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	ctx.fillStyle = "rgba(250,0,0,0.1)"; 
	ctx.beginPath();
	ctx.arc(w/2,h/2,50,0, Math.PI * 2 , false);
	ctx.fill();
    ctx.closePath();
	
	
}