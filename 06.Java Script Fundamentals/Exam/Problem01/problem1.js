function solve(params) {
    var nk = params[0].split(' ').map(Number),
        n = +nk[0],
        k = +nk[1],
        s = params[1].split(' ').map(Number),
        result = [],
        sum = 0;
    for (var i = 0; i < k; i++) {

        for (var j = 0; j < n; j++) {
            if (s[j] === 0) {
                if (j === 0) {
                    result[j] = Math.abs(s[n - 1] - s[j + 1]);
                }
                else if (j === n - 1) {
                    result[j] = Math.abs(s[j - 1] - s[0]);
                }
                else {
                    result[j] = Math.abs(s[j - 1] - s[j + 1]);
                }
                continue;
            }

            if (s[j] === 1) {
                if (j === 0) {
                    result[j] = s[n - 1] + s[j + 1];
                }
                else if (j === n - 1) {
                    result[j] = s[j - 1] + s[0];
                }
                else {
                    result[j] = s[j - 1] + s[j + 1];
                }
                continue;
            }

            if (!(s[j] % 2)) {
                if (j === 0) {
                    result[j] = Math.max(s[n - 1], s[j + 1]);
                }
                else if (j === n - 1) {
                    result[j] = Math.max(s[j - 1], s[0]);
                }
                else {
                    result[j] = Math.max(s[j - 1], s[j + 1]);
                }
                continue;
            }

            if (!!(s[j] % 2)) {
                if (j === 0) {
                    result[j] = Math.min(s[n - 1], s[j + 1]);
                }
                else if (j === n - 1) {
                    result[j] = Math.min(s[j - 1], s[0]);
                }
                else {
                    result[j] = Math.min(s[j - 1], s[j + 1]);
                }
            }
        }

        s = result.slice();
    }

    result.forEach(function (number) {
       sum += number;
    });
    return sum;
}

var test1 = [
    '5 20',
    '9 9 9 9 9'
];

//var test2 = [
//    '10 3',
//    '1 9 1 9 1 9 1 9 1 9'
//];

//var test3 = [
//    '10 10',
//    '0 1 2 3 4 5 6 7 8 9'
//];

console.log(solve(test1));
//console.log(solve(test2));
//console.log(solve(test3));