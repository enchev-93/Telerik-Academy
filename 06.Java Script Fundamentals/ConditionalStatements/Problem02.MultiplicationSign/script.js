function solveTask(a, b, c) {
	console.log('The sign of the three numbers product is: ');
	if (a > 0 && b > 0 && c > 0) {
		console.log('+');
	}
	else if (a < 0 && b < 0 && c < 0) {
		console.log('-');
	}
	else if (a > 0 && b > 0 && c < 0) {
		console.log('-');
	}
	else if (a > 0 && b < 0 && c < 0) {
		console.log('+');
	}
	else if (a > 0 && b < 0 && c > 0) {
		console.log('-');
	}
	else if (a < 0 && b > 0 && c > 0) {
		console.log('-');
	}
	else if (a < 0 && b > 0 && c < 0) {
		console.log('+');
	}
	else {
		console.log('+');
	}
}

solveTask(4.5, 3.4, 5.6);
solveTask(-4.5, -3.4, -5.6);
solveTask(4.5, 3.4, -5.6);
solveTask(4.5, -3.4, -5.6);
solveTask(4.5, -3.4, 5.6);
solveTask(-4.5, 3.4, 5.6);
solveTask(-4.5, 3.4, -5.6);
solveTask(-4.5, -3.4, 5.6);