function solveTask() {
    function extractURLElements(url) {
        var pattern = /(.*):\/\/(.*?)(\/.*)/g;

        return pattern.exec(url);
    }

    var urlAddress = "http://telerikacademy.com/Courses/Courses/Details/239";
    var fragments = extractURLElements(urlAddress);

    var jsonObject = JSON.stringify({
        protocol: fragments[1],
        server: fragments[2],
        resource: fragments[3]
    });

    console.log("JSON: " + jsonObject);

    var jsObject = JSON.parse(jsonObject);

    console.log("URL Address: " + urlAddress);
    console.log("[protocol] = " + jsObject.protocol);
    console.log("[server] = " + jsObject.server);
    console.log("[resource = " + jsObject.resource);
}

solveTask();