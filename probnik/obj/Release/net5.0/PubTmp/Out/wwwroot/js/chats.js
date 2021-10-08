"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatsHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message,myId,userId) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${user} says ${message} + ${myId} + ${userId}`;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    var myId = document.getElementById("myIdInput").value;
    var userId = document.getElementById("userIdInput").value;
    connection.invoke("SendMessage", user, message, userId, myId).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});