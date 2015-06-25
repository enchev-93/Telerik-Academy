function solveTask(obj, prop) {
    if (obj[prop]) {
        console.log('The object contains given property.');
    } else {
        console.log('Sorry! No such property.');
    }
}

solveTask(pesho = {
    name: 'Pesho',
    age: '69',
    objProp: {prop1: 4, prop2: 7}
}, 'value'); // change value to check containing properties