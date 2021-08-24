// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {  
    // Send an AJAX request  
    var rows = '';  
    $('#pedidos').empty();  
    $.getJSON(p,  
        function (data) {  
            $.each(data, function (key, val) {  
                var pedidosURL = pedidos + '/' + val.Codigo;  
                rows = rows + '<tr style="border: 1px solid black;"><td>  ' +  
                '<a style="color: Blue; font-weight:bold; font-size:15px"'  
                   + 'href="' + pedidosURL + '">' + val.Pedido + '</a>' +  
                    '</td><td>' + val.Codigo +  
                    '</td><td>' + val.Nome + 
                    '</td><td>' + val.Quantidade +
                    '</td><td>' + val.Valor + '</td></tr>';  
            });  
            $('#pedidos').html(rows);  
        });  
});    