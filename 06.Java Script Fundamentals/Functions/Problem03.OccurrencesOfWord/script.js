function solveTask(text, word, sensitive) {
    var caseSens = sensitive || false;
    var newStr = text.replace(/\W+/g, ' ');
    var words = newStr.split(' ');
    var ocurrences = 0;

    if (caseSens) {
        for (var i = 0; i < words.length; i += 1) {
            if (words[i] === word) {
                ocurrences += 1;
            }
        }
    } else {
        var lowerCase = word.toLowerCase();

        for (var j = 0; j < words.length; j += 1) {
            if (words[j].toLowerCase() == lowerCase) {
                ocurrences += 1;
            }
        }
    }

    return ocurrences;
}

console.log(solveTask('Welcome to JavaScript. JavaScript is awesome. Very awesome. Everybody love JavaScript', 'javascript', false));
console.log(solveTask('Welcome to JavaScript. JavaScript is awesome. Very awesome. Everybody love JavaScript', 'JavaScript', true));