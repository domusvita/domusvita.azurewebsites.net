$(document).ready(function () {

    $('#pager').val('@Model.Start');

    $('#pager').on('change', function () {
        window.location.href = $('#loader').data('request_url') + "?pageNumber=" + this.value;
    });

});