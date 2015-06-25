function solve(params) {
    var s = params[0], c1 = params[1], c2 = params[2], c3 = params[3];
    var answer = 0;
    for (var i = 0; i < s - c1 * i; i++) {
        for (var j = 0; j < s - c2 * j; j++) {
            for (var k = 0; k < s - c3 * k; k++) {
                var price = i * c1 + j * c2 + k * c3;
                if (price <= s) {
                    answer = Math.max(answer, price)
                } else {
                    break;
                }
            }
        }
    }

    return answer;
}

console.log(solve([110, 13, 15, 17]) == 110);
console.log(solve([20, 11, 200, 300]) == 11);
console.log(solve([110, 19, 29, 39]) == 107);
