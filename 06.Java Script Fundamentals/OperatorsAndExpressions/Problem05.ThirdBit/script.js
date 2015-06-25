function solveTask(number) {
	var message = 'The third bit of the given number is: ';
	if (number & (1 << 3) != 0) {
		console.log(message + 1);
	}
	else {
		console.log(message + 0);
	}
}

solveTask(3674);
solveTask(999);
solveTask(111);
solveTask(2730);