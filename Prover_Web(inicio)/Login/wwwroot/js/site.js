// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/*window.onload = function () { alert("Está carregado!") } */

const notific = document.querySelector("#notific")

var modal = document.getElementById("myModal");

var span = document.getElementsByClassName("close")[0];

function modall() {
    notific.addEventListener("click", function () {
        modal.style.display = "block";
    })


}


//notific.onclick = function () {
   
//}

span.onclick = function () {
    modal.style.display = "none";
}

window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
    }
}