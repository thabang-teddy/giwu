
$(document).ready(function () {
    $('#bibledatatables').DataTable({
        "mark": true,
        "ajax": {
            "url": "/BookLists/GetAll",
            "dataSrc": "",
        },
        "columns": [
            {
                "data": "name",
                "name": "Name",
            },
            {
                "data": "bookList",
                "name": "Book List",
            },
            {
                "data": "createdDate",
                "name": "Created Date",
            },
            {
                "data": "lastUpdatedDate",
                "name": "Last Updated Date",
            },
            {
                "data": "id",
                "name": "Action",
                "orderable": false,
                "searchable": false,
                "render": function (data) {
                    return (
                        '<ul class="orderDatatable_actions mb-0 d-flex flex-wrap">' +
                        '<li><a href="/BookLists/Details/' + data + '" class="view"><i class="fa fa-eye"></i></a></li>' +
                        '<li><a href="/BookLists/Edit/' + data + '" class="edit"><i class="fa fa-edit"></i></a></li>' +
                        '</ul>'
                    );
                },
                "className": 'text-center',
            }
        ]
    });
});