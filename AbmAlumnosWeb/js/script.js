function btn_loco() {
    alert("Presionaste el boton HTML")
}
function combo() {
    alert("cambios en el select")
}

// JSON: JavaScript Object Notation
/*
 * {
 *  nombre: "Jose",
 *  apellido: "Perez",
 *  edad: 35,
 *  hobbies: ["cocinar","jugar al futbol"],
 *  hijos: [
 *      {
 *          nombre: "roberto",
 *          edad: 10
 *      },
 *      {
 *          nombre: "martin",
 *          edad: 13
 *      }
 *      ]
 * }
 * 
 * 
 * */

$(document).ready(function () {
    buscarCursos();
})

function buscarCursos() {
    $.ajax({
        type: 'GET',
        url: 'AdministracionCursos.aspx/TablaCursos',
        data: {},
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            $("#body_cursos").html("");
            $.each(data.d, function (indice, valor) {
                console.log(valor)
                $("#body_cursos").append(
                    "<tr>" +
                    "<td>" + valor.Id_Curso + "</td>" +
                    "<td>PHP</td>" +
                    "<td>Programa de PHP</td>" +
                    "<td>" + valor.Aula.Nombre_Aula + "</td>" +
                    "<td>" + valor.Instructor.Nombre + " " + valor.Instructor.Apellido + "</td>" +
                    "</tr>"
                )
            })
        },
        error: function (error) {
            console.log(error);
        }
    })
}
