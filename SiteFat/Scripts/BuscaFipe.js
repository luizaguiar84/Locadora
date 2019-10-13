$(document).ready(function () {
    var urlBase = "//fipe.parallelum.com.br/api/v1/carros/marcas";

    /** Marcas**/

    $.getJSON(urlBase, function (data) {
        var items = ["<option value=\"\">Selecione a Montadora</option>"];
        $.each(data, function (key, val) {
            items += ("<option value='" + val.codigo + "'>" + val.nome + "</option>");
        });
        $("#Montadora").html(items);
    });

    /** Veiculo**/

    $("#Montadora").change(function () {
        $.getJSON(urlBase + "/" + jQuery("#Montadora").val() + "/" + "modelos", function (data) {
            var items = ["<option value=\"\">Selecione o Modelo</option>"];
            $.each(data.modelos, function (key, val) {
                items += ("<option value='" + val.codigo + "'>" + val.nome + "</option>");
            });
            $("#Modelo").html(items);
        });
    });

    /** Ano**/

    $("#Modelo").change(function () {
        $.getJSON(urlBase + "/" + jQuery("#Montadora").val() + "/" + "modelos" + "/" + jQuery("#Modelo").val() + "/" + "anos", function (data) {
            var items = ["<option value=\"\">Selecione o Ano</option>"];
            $.each(data, function (key, val) {
                console.log(data)
                items += ("<option value='" + val.codigo + "'>" + val.nome + "</option>");
            });
            $("#Ano").html(items);
        });
    });
});

