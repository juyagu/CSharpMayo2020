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

/*function sumatoria(num1, num2, sumar) {
    var resultado = sumar(num1, num2);
    console.log(resultado);
}*/




function sumar(n1, n2) {
    return n1 + n2;
}


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
                    "<td>"+ valor.Materia.Nombre +"</td>" +
                    "<td>"+ valor.Materia.Programa +"</td>" +
                    "<td>" + valor.Aula.Nombre_Aula + "</td>" +
                    "<td>" + valor.Instructor.Nombre + " " + valor.Instructor.Apellido + "</td>" +
                    "<td><button type='button' class='btn btn-primary' id='" + valor.Id_Curso + "' onclick='editarCurso()'>Editar</td>" +
                    "<td><button type='button' class='btn btn-danger' id='" + valor.Id_Curso + "' onclick='eliminarCurso("+ valor.Id_Curso +")'>Eliminar</td>" +
                    "</tr>"
                )
            })
        },
        error: function (error) {
            console.log(error);
        }
    })
}

function editarCurso() {
    alert('Presionaste el boton editar');
}

function eliminarCurso(id_curso) {
    if (confirm("Desea Eliminar el curso " + id_curso + "?")) {
        var obj = JSON.stringify({
            "id_curso": id_curso
        })
        $.ajax({
            type: 'POST',
            url: 'AdministracionCursos.aspx/EliminarCurso',
            data: obj,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data) {
                $("#body_cursos").html("");
                $.each(data.d, function (indice, valor) {
                    $("#body_cursos").append(
                        "<tr>" +
                        "<td>" + valor.Id_Curso + "</td>" +
                        "<td>" + valor.Materia.Nombre + "</td>" +
                        "<td>" + valor.Materia.Programa + "</td>" +
                        "<td>" + valor.Aula.Nombre_Aula + "</td>" +
                        "<td>" + valor.Instructor.Nombre + " " + valor.Instructor.Apellido + "</td>" +
                        "<td><button type='button' class='btn btn-primary' id='" + valor.Id_Curso + "' onclick='editarCurso()'>Editar</td>" +
                        "<td><button type='button' class='btn btn-danger' id='" + valor.Id_Curso + "' onclick='eliminarCurso(" + valor.Id_Curso + ")'>Eliminar</td>" +
                        "</tr>"
                    )
                })
            },
            error: function (error) {
                console.log(error);
            }
        })
    }
}

function guardarCurso() {
    // #nombre => id
    // .nombre => clase

    let materia = document.querySelector("#ContentPlaceHolder1_DropMaterias").value;
    let aula = document.querySelector("#ContentPlaceHolder1_DropAula").value;
    let ins = document.querySelector("#ContentPlaceHolder1_DropInstructor").value;
    let datos = JSON.stringify({
        "materia": materia,
        "aula": aula,
        "inst": ins
    })
    $.ajax({
        type: 'POST',
        url: 'AdministracionCursos.aspx/GuardarCurso',
        data: datos,
        contentType: 'application/json; charset=utf-8',
        dataType: 'json',
        success: function (data) {
            $("#body_cursos").html("");
            $.each(data.d, function (indice, valor) {
                $("#body_cursos").append(
                    "<tr>" +
                    "<td>" + valor.Id_Curso + "</td>" +
                    "<td>" + valor.Materia.Nombre + "</td>" +
                    "<td>" + valor.Materia.Programa + "</td>" +
                    "<td>" + valor.Aula.Nombre_Aula + "</td>" +
                    "<td>" + valor.Instructor.Nombre + " " + valor.Instructor.Apellido + "</td>" +
                    "<td><button type='button' class='btn btn-primary' id='" + valor.Id_Curso + "' onclick='editarCurso()'>Editar</td>" +
                    "<td><button type='button' class='btn btn-danger' id='" + valor.Id_Curso + "' onclick='eliminarCurso(" + valor.Id_Curso + ")'>Eliminar</td>" +
                    "</tr>"
                )
            })
        },
        error: function (error) {
            console.log(error);
        }
    })
}
