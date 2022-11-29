// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




// Get the modal
var modal = document.getElementById("modal");

// Get the button that opens the modal
var btn = document.getElementById("openModalBTN");

// Get the second modal
var modal2 = document.getElementById("modal2");

// Get the button that opens the second modal
var btn2 = document.getElementById("openModal2BTN");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// Get the <span> element that closes the modal
var span2 = document.getElementsByClassName("closeSecondModal")[0];

// When the user clicks on the button, open the modal
btn.onclick = function () {
    // This code is partially for the roster, as it checks for create and edit sections
    // It then disables the edit section and enables the create.
    modal.style.display = "block";
    var createmodal = document.getElementById("createshiftmodal");
    createmodal.style.display = "block";
    var editmodal = document.getElementById("editshiftmodal");
    editmodal.style.display = "none";
}

// When the user clicks on the second button, open the second modal
btn2.onclick = function () {
    modal2.style.display = "block";
}

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";

}

// When the user clicks on <span> (x), close the modal
span2.onclick = function () {
    modal2.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
    if (event.target == modal2) {
        modal2.style.display = "none";
    }
} 



