function solveTask(arr, num) {
    var answer = 0;
    for (var i = 0; i < arr.length; i += 1) {
        if (arr[i] === num) {
            answer += 1;
        }
    }

    return answer;
}

console.log(solveTask([1, 2, 3, 4, 1, 2, 3, 4, 1, 1, 3, 4, 6, 4, 2], 1));