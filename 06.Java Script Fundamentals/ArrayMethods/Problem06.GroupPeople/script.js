function Person(fname, lname, age, gender) {
    this.firstName = fname;
    this.lastName = lname;
    this.age = age;
    this.gender = !gender ? 'male' : 'female';
}

function compareFirstName(a, b) {
    if (a.firstName < b.firstName) {
        return -1;
    }

    if (a.firstName > b.firstName) {
        return 1;
    }

    return 0;
}

function printGroupedPeople(arr) {
    var result = {};
    arr = arr.sort(compareFirstName);

    arr.forEach(function (element) {
        result[element.firstName.toLowerCase()] = {firstname: element.firstName};
    });
    return JSON.stringify(result);
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

console.log(printGroupedPeople(arr));