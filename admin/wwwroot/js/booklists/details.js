$(document).ready(function () {
    $('#biblebookdatatables').DataTable({
        "mark": true,
        "columns": [
            {
                "data": "book",
                "name": "Book",
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
            }
        ],
        columnDefs: [
            {
                orderable: false,
                searchable: false,
                targets: 0,
                visible: false
            },
        ],
    });
});