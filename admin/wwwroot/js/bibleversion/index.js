
$(document).ready(function () {
    $('#bibledatatables').DataTable({
        "mark": true,
        "ajax": {
            "url": "/BibleVersions/GetAll",
            "dataSrc": "",
        },
        "columns": [
            {
                "data": "version",
                "name": "Version",
                "className": 'col-2',
            },
            {
                "data": "abbreviation",
                "name": "Abbreviation",
                "className": 'col-1',
            },
            {
                "data": "language",
                "name": "Language",
                "className": 'col-1',
            },
            {
                "data": "infoURL",
                "name": "Info URL",
                "className": 'col-2 text-truncate',
            },
            {
                "data": "copyright",
                "name": "Copyright",
                "className": 'col-3 text-center',
            },
            {
                "data": "id",
                "name": "Action",
                "orderable": false,
                "searchable": false,
                "render": function (data) {
                    return (
                        '<ul class="orderDatatable_actions mb-0 d-flex flex-wrap">' +
                        '<li><a href="/BibleVersions/Details/' + data + '" class="view"><i class="fa fa-eye"></i></a></li>' +
                        '<li><a href="/BibleVersions/Edit/' + data + '" class="edit"><i class="fa fa-edit"></i></a></li>' +
                        '</ul>'
                    );
                },
                "className": 'col-1 text-center',
            }
        ]
    });
});