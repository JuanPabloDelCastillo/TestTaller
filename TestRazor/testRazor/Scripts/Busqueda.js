$(document).ready(function () {    
    $("#btn-buscar").click(function () {
        obtenerVista();
    })
})

function obtenerVista() {
    var contenidoDelTextBox = $("#nombre").val();

    $.ajax({
        url: "/Clientes/Busqueda",
        data: { cliente: contenidoDelTextBox },
        type: "POST",
        success: function (data) {
            $('#CityID').html(data);
        } 
    })
}