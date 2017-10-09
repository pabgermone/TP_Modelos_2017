$(document).ready(function () {

    var e = $('#lblNotify')
    var s = $(e).html();
    var n = $(e).attr('data-type');

    if (s != '')
        notify(n, s);

    function notify(n, m) {

        var r = "Error!";
        var t = "danger";
        var i = "fa fa-times-circle-o";

        switch (n) {
            case "1":
                r = "Excelente!";
                t = "success";
                i = "fa fa-check-circle-o";
                break;

            case "2":
                r = "Atención!";
                t = "info";
                i = "fa fa-exclamation-triangle";
                break;

            case "3":
                r = "Atención!";
                t = "warning";
                i = "fa fa-exclamation-triangle";
                break;

            case "4":
                t = "danger"
                break;
        }

        var n = $.notify({
            title: r,
            icon: i,
            message: m,
            target: '_blank'
        }, {
            // Configuración
            
            type: t,
            delay: 5000,
            animate: {
                enter: 'animated bounceInDown',
                exit: 'animated fadeOutUp'
            },
            placement: {
                from: "top",
                align: "right"
            },
        });

        return n;
    }
});