function solveTask() {
    function generatePersonsArray(count) {
        var count = count || 20;

        var firstNames = ["John", "Liara", "Tali", "Urdnot", "Garrus"];
        var lastNames = ["Shepard", "T'soni", "Zorah", "Wrex", "Vakarian"];
        var age = [25, 33, 18, 69, 28];

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

    function group(arrPersons, key) {
        if (arrPersons.length === 0) {
            return undefined;
        }

        var answer = {};
        for (var prop in arrPersons[0]) {
            if (prop === key) {
                for (var i = 0; i < arrPersons.length; i += 1) {
                    if (!answer[arrPersons[i][key]]); {
                        answer[arrPersons[i][key]] = [];
                    }
                    answer[arrPersons[i][key]].push(arrPersons[i]);
                }
            }
        }

        return answer;
    }

    var persons = generatePersonsArray();
    var groupByAge = group(persons, "age");
    var groupByFirstName = group(persons, "firstName");
    var groupByLastName = group(persons, "lastName");

    console.log(groupByAge);
    console.log(groupByFirstName);
    console.log(groupByLastName);
}

solveTask();