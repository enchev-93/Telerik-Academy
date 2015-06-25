function solveTask(arr) {
	for (var i = 0; i < arr.length; i++) {
		var currMin = i;
		for (var j = i + 1; j < arr.length; j++) {
			if (arr[currMin] > arr[j]) {
				currMin = j;
			}
		}
		var helper = arr[i];
		arr[i] = arr[currMin];
		arr[currMin] = helper;
	}

	console.log(arr.join(', '));
}

solveTask([4, 3, 6, 8, 9, 2, 11, 0, -4, -2, 18]);