const canvas = document.getElementById("Game");
const ctx = canvas.getContext("2d");

const ground = new Image();
ground.src = "bg.png";

const foodImg = new Image();
foodImg.src = "food.png";

let box = 32;

let score = 0;

let food ={
	x: Math.floor(Math.random() *12 +1)*box,
	y: Math.floor(Math.random() *10 +1)*box
};

let snake = [];

snake[0] = {
	x:12*box,
	y:10 * box
};

document.addEventListener("keydown",direction);

let dir;

function direction() {
	if(event.keyCode == 37 && dir != "right")
		dir = "left";
	else if(event.keyCode == 40 && dir != "down")
		dir = "up";
	else if(event.keyCode == 39 && dir != "left")
		dir = "right";
	else if(event.keyCode == 38 && dir != "up")
		dir = "down";
}

function drawGame() {
	ctx.drawImage(ground,0,0);

	ctx.drawImage(foodImg,food.x,food.y);

	ctx.fillStyle = "red";
	ctx.fillRect(snake[0].x,snake[0].y,box,box);

	//Способ Рудика. В оригинале в цикле проверялось не является ли элемент первым и это глупо!
	for(let i = 1 ;i<snake.length;i++)
	{
		ctx.fillStyle = "orange";
		ctx.fillRect(snake[i].x,snake[i].y,box,box);
	}

	ctx.fillStyle = "white";
	ctx.font = "50px Arial";
	ctx.fillText(score,box*2.5,box*1.5);

	let snakeX = snake[0].x;
	let snakeY = snake[0].y;

	if(snakeX == food.x && snakeY == food.y)
	{
		score++;
		food ={
		x: Math.floor(Math.random() *12 +1)*box,
		y: Math.floor(Math.random() *10 +1)*box
		};
	}
	else
	{
		snake.pop();
	}

	if(snakeX<box|| snakeX>box*17 || snakeY<2*box|| snakeY>box*15)
	{
		clearInterval(game);
	}

	if(dir == "left") snakeX -=box;
	if(dir == "right") snakeX +=box;
	if(dir == "up") snakeY +=box;
	if(dir == "down") snakeY -=box;

	let newHead = {
		x:snakeX,
		y:snakeY
	};

	snake.unshift(newHead);
}

let game = setInterval(drawGame,100);