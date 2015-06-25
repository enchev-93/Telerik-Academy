function solveTask() {
    function generatePersonsArray(count) {
        var count = count || 20;

        var firstNames = ["John", "Liara", "Tali", "Urdnot"];
        var lastNames = ["Shepard", "T'soni", "Zorah", "Wrex"];
        var age = [25, 33, 18, 69];

        function getPerson(fname, lname, age) {
            return {
                firstName: fname,
                lastName: lname,
                age: age
            };
        }

        var persons = new Array(count);

        for (var i = 0; i < count; i += 1) {
            persons[i] = getPerson(
                firstNames[Math.floor((Math.random() * firstNames.length))],
                lastNames[Math.floor((Math.random() * lastNames.length))],
                age[Math.floor((Math.random() * age.length))]
            );
        }

        return persons;
    }

    var persons = generatePersonsArray();
    var youngestPerson = persons[0];

    for (var i = 0; i < persons.length; i++) {
        if (youngestPerson.age > persons[i].age) {
            youngestPerson = persons[i];
        }
    }

    console.log(youngestPerson);
}

solveTask();