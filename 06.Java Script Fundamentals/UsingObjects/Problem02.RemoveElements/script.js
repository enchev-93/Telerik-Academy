function solveTask (arr, element) {
    Array.prototype.remove = function (element) {
        for (var i = 0; i < this.length; i += 1) {
            if (this[i] === element) {
                this.splice(i, 1);
                i -= 1;
            }
        }
    };

    for (var i = 0; i < arr.length; i += 1) {
        console.log(arr[i] + " type is " + typeof arr[i]);
    }

    arr.remove(1);

    console.log("-----------------------");

    for (var j = 0; j < arr.length; j += 1) {
        console.log(arr[j] + " type is " + typeof  arr[j]);
    }
}

solveTask([1,2,1,4,1,3,4,1,111,3,2,1,'1']);