function solveTask() {
    function makeDeepCopy(obj) {
        return JSON.parse(JSON.stringify(obj));
    }

    var pesho = {
        name: "Pesho",
        age: 69,
        objProp: {prop1: 4, prop2: 7}
    };

    var deepCopy = makeDeepCopy(pesho);
    console.log(deepCopy);
}

solveTask();