$(document).ready(function () {
    $('.checkboxtoggle>input').bootstrapToggle({
        on: 'Urgente',
        onstyle: 'danger',
        off: 'Normal',
        offstyle: 'info'
    });
});