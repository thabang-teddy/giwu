
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
                {
                    "data": "action",
                    "name": "Action",
                    "orderable": false,
                    "searchable": false,
                    "render": function (data) {
                        return actionsHtml(data);
                    },
                    "className": 'text-end',
                }
            ],
        });

        $('#addNew').click(function () {
            $('#bookForm')[0].reset();
            $('#bookModal').modal('show');
        });

        $('#bookForm').on('submit', function (e) {
            e.preventDefault();
            var id = $('#bookId').val();
            var book = $('#book').val();
            var name = $('#name').val();
            var chapters = $('#chapters').val();
            var testament = $('#testament').val();
            var genre = $('#genre').val();

            if (id) {
                // Edit book
                var row = biblebookdatatables.row('#row_' + id);
                row.data([book, name, chapters, testament, genre]).draw(false);
            } else {
                // Add new book
                var newId = new Date().getTime(); // Using timestamp as unique ID
                biblebookdatatables.row.add([book, name, chapters, testament, genre]).draw(false).node().id = 'row_' + newId;
            }
            $('#bookModal').modal('hide');
        });

        $('#biblebookdatatables tbody').on('click', '.edit', function () {
            var data = biblebookdatatables.row($(this).parents('tr')).data();
            var newId = new Date().getTime();
            // $('#bookId').val(newId);
            $('#bookId').val($(this).data('id'));
            $('#book').val(data["book"]);
            $('#name').val(data["name"]);
            $('#chapters').val(data["chapters"]);
            $('#testament').val(data["testament"]);
            $('#genre').val(data["genre"]);
            $('#bookModal').modal('show');
        });

        $('#biblebookdatatables tbody').on('click', '.delete', function () {
            if (confirm('Are you sure to delete this record?')) {
                biblebookdatatables.row($(this).parents('tr')).remove().draw();
            }
        });

        function actionsHtml(id) {
            return '<button class="btn btn-sm btn-warning view" data-id="' + id + '" type="button"><i class="fa fa-eye"></i></button>' +
                '<button class="btn btn-sm btn-warning edit mx-2" data-id="' + id + '" type="button"><i class="fa fa-edit"></i></a></button> ' +
                '<button class="btn btn-sm btn-danger delete" data-id="' + id + '" type="button"><i class="fa fa-trash"></i></a></button>';
        }
    }

});