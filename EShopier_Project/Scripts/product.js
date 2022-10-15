var productid = -1;
var modalproductBodyId = "#modalproduct_body";

$(function () {
    $('#modalproduct').on('show.bs.modal', function (e) {

        var btn = $(e.relatedTarget);
        var productid = btn.data("product-id");

        $("modalproduct_body").load("/Products/ShowProduct/" + productid);
    })
})
