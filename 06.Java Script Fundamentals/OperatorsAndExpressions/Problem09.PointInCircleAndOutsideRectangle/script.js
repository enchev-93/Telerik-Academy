function solveTask(x, y) {
	var isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= 3 * 3;
	var isOutOfRectangle = !((x >= -1 && x <= -1 + 6) && (y <= 1 && y >= 1 - 2));
	return isInCircle && isOutOfRectangle;
}

console.log(solveTask(7, 6));
console.log(solveTask(2, 2));
console.log(solveTask(1.3, 2));
console.log(solveTask(6, 4));