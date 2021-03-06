﻿$('#btn-load-more').on('click', function (e) {
    e.preventDefault();
    let that = $(this);
    let currentPage = +($('#current-page').data('page-nr'));
    that.find('i').attr('class', 'fa fa-spinner fa-pulse');
    $.ajax({
        url: $(this).data('request-url'),
        type: "POST",
        data: { currentPage },
        success: function (data) {
            that.find('i').attr('class', 'fa fa-chevron-down');
            currentPage++;
            $('#current-page').data('page-nr', currentPage)
            $('#collection').append(data);
        }
    })
});

$('#btn-add-to-cart').on('click', function (e) {
    e.preventDefault();
    let that = $(this).closest('.product-card');
    console.log(that);

});