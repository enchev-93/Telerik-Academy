function solveTask() {
    var input = '((a+b)/5-d)';

    function isValidExpression(expression) {
        var bracketCount = 0;

        for (var i = 0; i < expression.length; i += 1) {
            if (expression[i] == '(') {
                bracketCount += 1;
            } else if (expression[i] == ')') {
                bracketCount -= 1;
            }

            if (bracketCount < 0) {
                return false;
            }
        }

        return bracketCount === 0;
    }

    var isValid = isValidExpression(input);
    console.log(isValid);
}

solveTask();