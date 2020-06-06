// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function like(x) {
  x.classList.toggle("fa-thumbs-down");
}
$('#ReservePlacesModal').on('shown.bs.modal', function () {
    $('#myInput').trigger('focus')
})
$(window).scroll(function () {
    if ($(document).scrollTop() > 50) {
        $('nav').addClass('shrink');
    } else {
        $('nav').removeClass('shrink');
    }
});