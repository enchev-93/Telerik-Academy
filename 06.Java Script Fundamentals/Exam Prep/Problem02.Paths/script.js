function solve(args) {
    var rowsCols = args[0].split(' '),
        bounds = {
            rows: +rowsCols[0],
            cols: +rowsCols[1]
        },
        matrix = args.slice(1)
            .map(function(line) {
                return line.split(' ');
            }),
        row = 0,
        col = 0,
        sum = 0,
        dir,
        deltas = {
            u: -1,
            d: +1,
            l: -1,
            r: +1
        },
        leftRight,
        upDown,
        used = {},
        key;

    while(true) {
        if (!matrix[row] || !matrix[row][col]) {
            return 'successed with ' + sum;
        }
        key = row + ';' + col;
        if (used[key]) {
            return 'failed at (' + row + ', ' + col +')';
        }

        used[key] = true;
        sum += (1 << row) + col;
        dir = matrix[row][col];
        upDown = dir[0];
        leftRight = dir[1];
        row += deltas[upDown];
        col += deltas[leftRight];
    }

    return matrix;
}

var tests = [
    [
        '3 5',
        'dr dl dr ur ul',
        'dr dr ul ur ur',
        'dl dr ur dl ur'
    ],
    [
        '3 5',
        'dr dl dl ur ul',
        'dr dr ul ul ur',
        'dl dr ur dl ur'
    ]
];

tests.forEach(function(test) {
    console.log(solve(test));
});