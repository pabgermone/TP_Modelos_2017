jQuery(document).ready(function ($) {

    $('#BandejaProductos').DataTable({
        destroy: configDataTable.destroy,
        aaSorting : [[0, 'asc']],
        language: configDataTable.language,
        lengthMenu: configDataTable.lengthMenu
    });

    $('#BandejaBitacora').DataTable({
        destroy: configDataTable.destroy,
        aaSorting: [[0, 'desc']],
        language: configDataTable.language,
        lengthMenu: configDataTable.lengthMenu
    });


    if ($(".filter-block").html() == "")
        $(".filters").addClass("hidden");

    function SelectFilter(table, columns, widthColumn) {
        var i = 0;
        table.api().columns(columns).every(function (index) {
            var column = this;

            var select = $('<div class="col-lg-' + widthColumn[i] + '"><div class="form-group"><label>' + $(column.header()).attr('title') + '</label><div><select id="ucBandejaTicket_Filtro_' + $(column.header()).attr('title') + '" class="form-control input-sm"><option value="-1">--SELECCIONE--</option></select></div></div></div>')
                .appendTo('.filter-block')
                .on('change', function () {
                    var val = "";

                    if ($(this).find(':selected').val() != "-1") {
                        val = $.fn.dataTable.util.escapeRegex($(this).find(':selected').text());
                    }

                    column
                        .search(val ? '^' + val + '$' : '', true, false)
                        .draw();
                });
            i++;
            column
                .cache('search')
                .sort()
                .unique()
                .each(function (d, j) {
                    select.children().children().children().append("<option>" + d + "</option>");
                });
        });
    }

    function SearchFilter(dropDownList, table) {
        $(dropDownList).on('change', function (event) {
            var r = $(this).find(':selected');

            if (r.val() > 0 && table.search() != r.text()) {
                table
                    .search(r.text().trim())
                    .draw();
            } else {
                table
                    .search('')
                    .draw();
            }
        });
    }
});