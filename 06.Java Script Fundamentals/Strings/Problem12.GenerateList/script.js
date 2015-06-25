function generatePersonsArray(count) {
    var count = count || 20;

    var names = ["John", "Tali", "Liara", "Wrex", "James", "Garrus"];
    var ages = [26, 23, 103, 58, 30, 33];

    function getPerson(fname, age) {
        return {
            name: fname,
            age: age
        };
    }

    var persons = new Array(count);

    for (var i = 0; i < count; i += 1) {
        persons[i] = getPerson(
            names[Math.floor(Math.random() * names.length)],
            ages[Math.floor(Math.random() * ages.length)]
        );
    }

    return persons;
}