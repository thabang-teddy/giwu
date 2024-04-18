var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#datatables').DataTable({
        "ajax": { url: '/BibleView/getall' },
        "columns": [
            { data: 'version', "width": "25%" },
            { data: 'abbreviation', "width": "15%" },
            { data: 'language', "width": "10%" },
            { data: 'infoURL', "width": "15%" },
            { data: 'copyright', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/BibleView/Details/${data}" class="btn btn-primary mx-2"> <i class="bi bi-eye"></i> Details</a>
                    </div>`;
                },
                "width": "25%"
            }
        ]
    });
}
