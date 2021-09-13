"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (userId, message,date) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${userId} \n ${message} \n ${date}`;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var userId = document.getElementById("userIdInput").value;
    var message = document.getElementById("messageInput").value;
    var date = document.getElementById("dateInput").value;
    connection.invoke("SendMessage", userId, message,date).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});