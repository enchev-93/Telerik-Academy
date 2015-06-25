function solveTask(arr, pos) {
    if (pos <= 0 || pos >= arr.length - 1) {
        console.log("Take another element's position");
    } else {
        if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1]) {
            console.log(true);
        } else {
            console.log(false);
        }
    }
}

solveTask([1, 2, 3, 4, 3, 5, 1, 2, 3, 2], 3);