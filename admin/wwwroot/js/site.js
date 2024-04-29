// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $(".chapter").on("click", (e) => {

        var chapter = e.currentTarget.getAttribute("data-chapter");
        // var dataChapter = $(this).attr("data-chapter");

        // Example of using $.ajax() to make a GET request
        $.ajax({
            url: '/BibleView/GetChapter/' + chapter,  // URL to which the request is sent
            type: 'GET',                         // Type of request to be made
            success: function (data, textStatus, xhr) {
                $('#bibleModal').modal('show');
                console.log('Response received:', data);  // Called when the request succeeds
            },
            error: function (xhr, textStatus, errorThrown) {
                console.error('Error in request:', errorThrown);  // Called when the request fails
            }
        });
    });
});

