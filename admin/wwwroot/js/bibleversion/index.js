
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
                    return '<a href="/BibleVersions/Details/' + data + '"><i class="fa fa-eye"></i></a>';
                },
                "className": 'col-1 text-center',
            }
        ]
    });
});