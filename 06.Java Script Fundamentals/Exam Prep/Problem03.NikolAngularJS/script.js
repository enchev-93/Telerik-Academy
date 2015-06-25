function solve(args) {
    var n = parseInt(args[0]);
    var model = {};
    for (var i = 0; i < n; i++) {
        var keyValuePair = args[i + 1].split('-');
        var key = keyValuePair[0];
        var value = keyValuePair[1];

        if (value == 'true') {
            value = true;
        }
        else if (value == 'false') {
            value = false;
        }
        else if (value.indexOf(';') > -1) {
            value = value.split(';');
        }

        model[key] = value;
    }

    var inModel = false;
    var escaped = false;
    var inTemplate = false;

    var modelOpenTag = '<nk-model>';
    var modelCloseTag = '</nk-model>';
    var templateOpenTag = '<nk-template name="';
    var templateCloseTag = '</nk-template>';
    var escapeOpen = '{{';
    var escapeClose = '}}';

    var currentModel = '';
    var currentTemplateName = '';
    var currentTemplateContent = [];

    var allTemplate = {};

    var result = [];

    var m = parseInt(args[n + 1]);
    for (var j = n + 2; j < n + m + 2; j++) {
        var currentLine = args[j];
        if (currentLine == undefined) {
            currentLine = '';
        }

        if (inTemplate) {
            currentTemplateContent.push('\n');
        }

        for (var k = 0; k < currentLine.length; k++) {
            var currentSymbol = currentLine[k];

            //escape starts
            if (checkForCommand(currentLine, escapeOpen)) {
                escaped = true;
                k += 1;
                continue;
            }

            //escape ends
            if (escaped && checkForCommand(currentLine, escapeClose)) {
                escaped = false;
                k += 1;
                continue;
            }

            //escaped content pushed to result
            if (escaped) {
                result.push(currentSymbol);
                continue;
            }

            //check if section is defined
            if (checkForCommand(currentLine, templateOpenTag)) {
                inTemplate = true;
                currentTemplateName = currentLine.split('"')[1];
                break;
            }

            // check ending of section definition
            if (inTemplate && checkForCommand(currentLine, templateCloseTag)) {
                inTemplate = false;

                allTemplate[currentTemplateName] = currentTemplateContent.join('').trim();
                currentTemplateName = '';
                currentTemplateContent = [];
                break;
            }

            //append to current template
            if (inTemplate) {
                currentTemplateContent.push(currentSymbol);
            }

            //check if model tag is opened
            if (checkForCommand(currentLine, modelOpenTag)) {
                inModel = true;
                k += modelOpenTag.length - 1;
                continue;
            }

            //check if model rendering ends
            if (inModel && checkForCommand(currentLine, modelCloseTag)) {
                inModel = false;

                if (model[currentModel]) {
                    result.push(model[currentModel]);
                }

                currentModel = '';
                k += modelCloseTag.length - 1;
                continue;
            }

            //check if in model
            if (inModel) {
                currentModel += currentSymbol;
                continue;
            }

            result.push(currentSymbol);
        }

        result.push('\n');
    }

    console.log(result.join('').trim());

    function checkForCommand(currentLine, tag) {
        return currentLine.substr(k, tag.length) == tag;
    }
}

var test = [
'6',
'title-Telerik Academy',
'showSubtitle-true',
'subTitle-Free training',
'showMarks-false',
'marks-3;4;5;6',
'students-Ivan;Gosho;Pesho',
'42',
'<nk-template name="menu">',
'<ul id="menu">',
'<li>Home</li>',
'<li>About us</li>',
'</ul>',
'</nk-template>',
'<nk-template name="footer">',
'<footer>',
'Copyright Telerik Academy 2014',
'</footer>',
'</nk-template>',
'<!DOCTYPE html>',
'<html>',
'<head>',
'<title>Telerik Academy</title>',
'</head>',
'<body>',
'<nk-template render="menu" />',
    '',
'<h1><nk-model>title</nk-model></h1>',
'<nk-if condition="showSubtitle">',
'<h2><nk-model>subTitle</nk-model></h2>',
'<div>{{<nk-model>subTitle</nk-model>}} ;)</div>',
'</nk-if>',
    '',
'<ul>',
'<nk-repeat for="student in students">',
'<li>',
'<nk-model>student</nk-model>',
'</li>',
'<li>Multiline <nk-model>title</nk-model></li>',
'</nk-repeat>',
'</ul>',
'<nk-if condition="showMarks">',
'<div>',
'<nk-model>marks</nk-model>',
'</div>',
'</nk-if>',
    '',
'<nk-template render="footer" />',
'</body>',
'</html>'
];

solve(test);