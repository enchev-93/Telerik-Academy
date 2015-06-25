function solveTask(arr) {
    var hasFound = false;
    for (var i = 1; i < arr.length - 1; i += 1) {
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
            hasFound = true;
            return i;
        }
    }

    if (!hasFound) {
        return -1;
    }
}

console.log(solveTask([1, 2, 3, 4, 3, 5,1, 2, 1]));
console.log(solveTask([1, 1, 1, 1, 1]));