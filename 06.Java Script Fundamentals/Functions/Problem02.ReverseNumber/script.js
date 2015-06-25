function solveTask(number) {
    for (var r = 0; number; number = Math.floor(number/10)) {
        r *= 10;
        r += number % 10;
    }

    console.log(r);
}

solveTask(256);