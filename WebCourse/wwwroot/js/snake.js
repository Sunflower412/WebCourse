const canvas = document.getElementById("gameCanvas");
const ctx = canvas.getContext("2d");

let snake = [{ x: 160, y: 160 }];
let direction = { x: 20, y: 0 };
let food = spawnFood();
let score = 0;

document.addEventListener("keydown", changeDirection);
setInterval(gameLoop, 100);

function gameLoop() {
    update();
    draw();
}

function update() {
    const head = { x: snake[0].x + direction.x, y: snake[0].y + direction.y };

    // Проверка на столкновение с самою собой или стенами
    if (head.x < 0 || head.y < 0 || head.x >= canvas.width || head.y >= canvas.height || collision(head)) {
        alert("Игра окончена! Ваш счёт: " + score);
        document.location.reload();
        return;
    }

    snake.unshift(head);

    // Проверка на сбор пищи
    if (head.x === food.x && head.y === food.y) {
        score++;
        food = spawnFood();
        document.getElementById('score').innerText = "Счет: " + score;
    } else {
        snake.pop();
    }
}

function spawnFood() {
    const x = Math.floor(Math.random() * (canvas.width / 20)) * 20;
    const y = Math.floor(Math.random() * (canvas.height / 20)) * 20;
    return { x, y };
}

function collision(head) {
    return snake.some(segment => segment.x === head.x && segment.y === head.y);
}

function changeDirection(event) {
    switch (event.key) {
        case "ArrowUp":
            if (direction.y === 0) direction = { x: 0, y: -20 };
            break;
        case "ArrowDown":
            if (direction.y === 0) direction = { x: 0, y: 20 };
            break;
        case "ArrowLeft":
            if (direction.x === 0) direction = { x: -20, y: 0 };
            break;
        case "ArrowRight":
            if (direction.x === 0) direction = { x: 20, y: 0 };
            break;
    }
}

function draw() {
    ctx.clearRect(0, 0, canvas.width, canvas.height);

    // Рисуем пищу
    var imgFood = new Image();
    imgFood.src = "~/img/lightning.jpg";
    imgFood.onload = function () {
        ctx.drawImage(imgFood, food.x, food.y, 20, 20);
    };

    // Рисуем змею
    for (let i = 0; i < snake.length; i++) {
        var imgSnakePart = new Image();
        imgSnakePart.src = "~/img/lastochka.jpg"; // Текстура для тела змеи
        if (i === 0) {
            imgSnakePart.src = "~/img/lastocha.jpg"; // Текстура для головы змеи
        }

        imgSnakePart.onload = function () {
            ctx.drawImage(imgSnakePart, snake[i].x, snake[i].y, 20, 20);
        };
    }
}
