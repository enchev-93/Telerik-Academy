function solveTask() {
    function extractValidEmails(text) {
        var pattern = /(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))/g;
        var validEmails = text.match(pattern);

        return validEmails;
    }

    var text = 'asd@gmail.com, pesho.peshev@yahoo.co.uk, (+359 123 456 789, test@test, @gmail.com, a@a.b, valid@email.com, pesho, <somemail@gmal.com>, <asd@asdjosajidjasijfioncasd.com>, <manager@yadiad.in';
    var validEmails = extractValidEmails(text);

    for (var email in validEmails) {
        console.log(validEmails[email])
    }
}

solveTask();
