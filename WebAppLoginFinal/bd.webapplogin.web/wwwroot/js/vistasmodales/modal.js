// En un Action.Link 
//@Html.ActionLink("Nombre del Botón", "Acción del Controlador", "Nombre del Controlador", new { parametro = Model.parametro }, new { @class = "dialog-window" })
// En la sección new { @class = "dialog-window" } de la linea anterior debe coincidir con a.dialog-window de la linea
//  $("body").on("click", "a.dialog-window", null, function (e) 
// De este documento javascript
// Para mostrar el modal se debe incluir la siguiente linea en la vista en el que está ubicado el Action.Link
//@{await Html.RenderPartialAsync("Modal", new bd.webappth.entidades.Negocio.IndiceOcupacionalActividadesEsenciales());}
// En la linea anterior el primer parámetro "Modal" es el nombre de la vista modal y el segundo parámetro el el modelo de la vista que ejecuta el Action.Link
// La acción del Action.Link debe retornar un PartialView en el Controlador que será los datos a mostrar





$(document).ready(function () {
    $('body').on('click', 'a.dialog-window', function (e) {
        mostrarLoadingPanel("content", "Cargando...")
        e.preventDefault();
        var $link = $(this);
        var title = $link.text();
        $('#myModal.modal-title').html(title);
        var url = $(this).attr('href');
        if (url.indexOf('#') == 0) {
            $('#myModal').modal('show');         
            $("#myModal").waitMe("hide");
        }
        else {
            $.get(url, function (data) {              
                $('#myModal .te').html(data);
                $('#myModal').modal();
                $('#selectC').select2();
                $("#content").waitMe("hide");
            }).success(function () { $('input:text:visible:first').focus(); });

        }
    });
});



