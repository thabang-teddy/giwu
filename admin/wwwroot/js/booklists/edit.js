
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
            },
            {
                "data": "id",
                "name": "Action",
                "orderable": false,
                "searchable": false,
                "render": function (data) {
                    return (
                        '<ul class="orderDatatable_actions mb-0 d-flex flex-wrap">' +
                        '<li><a href="#" class="view"><i class="fa fa-eye"></i></a></li>' +
                        '<li><a href="#" class="edit"><i class="fa fa-edit"></i></a></li>' +
                        '</ul>'
                    );
                },
                "className": 'text-end',
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