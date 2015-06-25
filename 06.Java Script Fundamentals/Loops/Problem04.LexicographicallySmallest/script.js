function solveTask(objects) {
	for (var object in objects) {
		var properties = [];
		
		for (var property in objects[object]) {
			properties.push(property);
		}

		properties.sort();
		
		console.log('Smallest property: ' + properties.shift());
		console.log('Largest property: ' + properties.pop());
	}
}

solveTask([document, window, navigator]);