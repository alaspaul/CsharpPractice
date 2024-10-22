document.querySelector("#loadPersonsButton").addEventlistener("click", async function () {


    var response = await fetch("/Persons", { method: "GET" });

    var responseBody = await response.text();

    document.querySelector("#personlist").innerHTML = responseBody;
});