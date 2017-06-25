$('#btn-load-more').click(function () {
    let that = $(this);
    let currentPage = +($('#current-page').data('page-nr'));
    that.find('i').attr('class', 'fa fa-spinner fa-pulse');
    $.ajax({
        url: $(this).data('request-url'),
        type: "GET",
        data: { currentPage },
        success: function (data) {
            that.find('i').attr('class', 'fa fa-chevron-down');
            currentPage++;
            $('#current-page').data('page-nr', currentPage)
            $('#collection').append(data);
        }
    })
});