function solveTask(numbersSet) {
	numbersSet.sort();
	console.log('min = ' + numbersSet[0]);
	console.log('max = ' + numbersSet[numbersSet.length - 1]);
}

solveTask([1, 2, 3, 4, 5]);
solveTask([99, 25, 38, 29, 16, 18]);
solveTask([3636, 7823, 2290, 2829]);