// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// site.js

// Example of a simple JavaScript function to alert the user when they are trying to delete a patient
function confirmDelete(patientName) {
    var result = confirm("Are you sure you want to delete the patient " + patientName + "?");
    return result;
}

// Disable submit button after form submission to prevent multiple submissions
document.addEventListener('DOMContentLoaded', function () {
    var form = document.querySelector('form');
    if (form) {
        form.addEventListener('submit', function (e) {
            var submitButton = form.querySelector('button[type="submit"]');
            submitButton.disabled = true;
            submitButton.innerHTML = "Processing...";
        });
    }
});
