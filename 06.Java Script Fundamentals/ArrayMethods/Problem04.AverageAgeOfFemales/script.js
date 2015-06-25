function Person(fname, lname, age, gender) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = age;
    this.gender = !gender ? 'male' : 'female';
}

function printAverageAgeOfFemales(arr) {
    arr = arr.filter(function (item) {
        return item.gender == 'female';
    });

    var sumOfAges = 0;
    arr.forEach(function (item) {
        sumOfAges += item.age | 0;
    });

    return (sumOfAges / arr.length).toFixed(2);
}

var arr = [
    new Person('John', 'Shepard', '26', false),
    new Person('Tali', 'Zhora', '23', true),
    new Person('Garrus', 'Vakarian', '32', false),
    new Person('Liara', 'Tsoni', '103', true),
    new Person('Urdnot', 'Wrex', '58', false),
    new Person('Miranda', 'Lawson', '29', true),
    new Person('James', 'Vega', '30', false),
    new Person('Ashley', 'Williams', '26', true),
    new Person('David', 'Anderson', '53', false),
    new Person('Jeff', 'Moreau', '35', false)
];

console.log(printAverageAgeOfFemales(arr));