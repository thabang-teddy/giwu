
$(document).ready(function () {
    var biblebookdatatables;
    if ($('#biblebookdatatables')) {
        biblebookdatatables = $('#biblebookdatatables').DataTable({
            "mark": true,
            "columns": [
                {
                    "data": "book",
                    "name": "Book",
                    "title": "#",
                },
                {
                    "data": "name",
                    "name": "Name",
                },
                {
                    "data": "chapters",
                    "name": "Chapters",
                    "className": 'text-center',
                },
                {
                    "data": "testament",
                    "name": "Testament",
                    "className": 'text-center',
                },
                {
                    "data": "genre",
                    "name": "Genre",
                    "className": 'text-center',
                },
            ],
        });
    }

});