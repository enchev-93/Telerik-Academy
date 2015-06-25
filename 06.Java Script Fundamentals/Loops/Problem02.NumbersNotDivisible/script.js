function solveTask(number) {
	for (var i = 1; i <= number; i++) {
		if (i % 3 === 0 && i % 7 === 0) {
			console.log(i);
		}
	}
}

solveTask(5);
solveTask(999);
solveTask(28713);