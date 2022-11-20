// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Get the prognose modal
var prognoseModal = document.getElementById("prognoseModal");

// Get the button that opens the modal
var btn = document.getElementById("openPrognoseModalbtn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks on the button, open the modal
btn.onclick = function () {
    prognoseModal.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    prognoseModal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == prognoseModal) {
        prognoseModal.style.display = "none";
    }
} 