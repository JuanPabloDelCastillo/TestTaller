$(document).ready(function () {
    Venta.setupAutoComplete();
})

var Venta = function () {

}

Venta.setupAutoComplete = function () {
    $.ajax({
        url: '/Productos/ObtenerNombreProductos',
        success: function (data) {
            $('#txt-producto').AutoComplete({
                source: data,
                focus: function (event, ui) {
                    $("#txt-producto").val(ui.item.Name);
                }
            })
        }
    })
}