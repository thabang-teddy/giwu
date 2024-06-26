$(document).ready(function () {
    $("#book-list").find(".chapter").on("click", (e) => {

        var bible = e.currentTarget.getAttribute("data-bible");
        var book = e.currentTarget.getAttribute("data-book");
        var chapter = e.currentTarget.getAttribute("data-chapter");

        $.ajax({
            url: '/BibleVersions/GetChapter', // Replace with your server endpoint
            method: 'POST',
            data: {
                bible: bible,
                chapter: chapter,
                book: book
            },
            success: function (response) {
                // Inject the returned HTML into the modal body
                $('#bibleModal').find('.modal-body').html(response);

                // Show the modal
                $('#bibleModal').modal('show');
            },
            error: function (error) {
                console.error('Error in request:', error);
            }
        });
    })
});