function solveTask() {
    function extractPalindromes(text) {
        var palindromes = [];
        var currentWord = "";
        var regex = /\b\w+\b/g;

        while (currentWord = regex.exec(text)) {
            if (isPalindrome(currentWord[0])) {
                palindromes.push(currentWord[0]);
            }
        }

        return palindromes;
    }

    function isPalindrome(word) {
        for (var i = 0; i < word.length / 2; i += 1) {
            if (word.charAt(i) != word.charAt(word.length - i - 1)) {
                return false;
            }
        }

        return true;
    }

    var text = 'ABBA, palindrome. lamal, EXEasd, exe, tacocat, no palindromes here, racecar, eye, madamimadam';
    var palindromes = extractPalindromes(text);

    console.log("All palindromes: " + palindromes.join(', '));
}

solveTask();