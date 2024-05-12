// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $(".chapter").on("click", (e) => {

        var bible = e.currentTarget.getAttribute("data-bible");
        var book = e.currentTarget.getAttribute("data-book");
        var chapter = e.currentTarget.getAttribute("data-chapter");

        // Example of using $.ajax() to make a POST request
        $.ajax({
            type: 'POST',        // Specifies the type of request
            url: '/BibleView/GetChapter',  // The URL to which the request is sent
            data: {              // Data to send
                bible: bible,
                chapter: chapter,
                book: book
            },
            success: function (response) {  // A function to be called if the request succeeds
                $('#bibleModal').modal('show');
                // console.log('Response received:', response.data);  // Called when the request succeeds
                $("#bibleModal").find(".modal-body").html(response); // Display the returned partial view
            },
            error: function (xhr, status, error) {  // A function to be called if the request fails
                console.error('Error in request:', error);
            },
        });

    });
});

