function solveTask() {
    var text = 'Pesho is    very cool  .';
    var newSubstring = '&nbsp;';

    console.log(text);
    var result = text.replace(/ /g, newSubstring);
    console.log(result);
}

solveTask();