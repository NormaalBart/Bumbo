// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




// Get the modal
var modal = document.getElementById("modal");

// Get the button that opens the modal
var btn = document.getElementById("openModalBTN");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

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

// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
    selectedshiftidedit = 0;

}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
        selectedshiftidedit = 0;
    }
} 



// Get the edit modal
var editmodal = document.getElementById("editmodal");

// Get the button that opens the modal
var editmodalbtn = document.getElementById("openEditModalBtn");

// Get the <span> element that closes the modal
var editspan = document.getElementsByClassName("close")[0];



// When the user clicks on <span> (x), close the modal
editspan.onclick = function () {
    modal.style.display = "none";
}

