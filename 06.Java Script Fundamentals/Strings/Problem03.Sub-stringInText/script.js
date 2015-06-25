function solveTask() {
    function allOccurrencesLength(str, patter, isCaseSensitive) {
        var modifier = isCaseSensitive ? "g" : "gi";
        var regex = new RegExp(patter, modifier);

        return str.match(regex).length;
    }

    var text = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
    var searchedSubstring = "in";
    var count = allOccurrencesLength(text, searchedSubstring, false);

    console.log(count);
}

solveTask();