function solve(params) {
    var rows = parseInt(params[0]),
        cols = parseInt(params[1]),
        tests = parseInt(params[rows + 2]), i, move;
    for (i = 0; i < tests; i++) {
        move = params[rows + 3 + i];
        // Your solution here
        console.log('yes'); // or console.log('no');
    }
}


var test1 = [
    '3', //R - rows
    '4', //C - cols
    '--R-',
    'B--B',
    'Q--Q',
    '12', //T - moves
    'd1 b3',
    'a1 a3',
    'c3 b2',
    'a1 c1',
    'a1 b2',
    'a1 c3',
    'a2 b3',
    'd2 c1',
    'b1 b2',
    'c3 b1',
    'a2 a3',
    'd1 d3'
];

console.log(solve(test1));