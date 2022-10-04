//Botones que abren el modal y la caja div de Registrate.
$('#btnAbrirModal').on('click', VerParticipantes);
$('#btnAbrirModal2').on('click', NuevoRegistro);

document.addEventListener('keyup', e => {
    if (e.key == 'Escape') {
        $('#modal-section').empty();
        document.querySelector('.es-visible').classList.remove('es-visible');

    }
});


function LlamarAcampante() {
    $.ajax({
        // la URL para la petición
        url: 'https://localhost:7216/API/Acampantes/Obtener',

        // la información a enviar
        // (también es posible utilizar una cadena de datos)
        data: {

        },

        // especifica si será una petición POST o GET
        type: 'GET',

        // el tipo de información que se espera de respuesta
        dataType: 'json',

        // código a ejecutar si la petición es satisfactoria;
        // la respuesta es pasada como argumento a la función
        success: function (json) {
            $('.Registrados').append(`<h2>Nombre</h2>`);
            $.each(json, (i, v) => {
                /*console.log(v.firstname);*/
                $('.Registrados').append(`<div class="card">
                                          <div class="content">                                                                                         
                                              <p>${v.firstName},${v.lastName}</p>
                                          </div>`);
            })
        },

        // código a ejecutar si la petición falla;
        // son pasados como argumentos a la función
        // el objeto de la petición en crudo y código de estatus de la petición
        error: function (xhr, status) {
            console.log('Disculpe, hubo un error');
        },

        // código a ejecutar sin importar si la petición falló o no
        complete: function (xhr, status) {
            console.log('Petición llamar acampantes realizada');
        }
    });
}


function VerParticipantes() {

    let Id_modal = this.dataset.abrir;
    document.getElementById(Id_modal).classList.add('es-visible');

    $.ajax({
        // la URL para la petición
        url: 'https://localhost:7216/api/Organizador/Obtener',
        // la información a enviar
        // (también es posible utilizar una cadena de datos)
        data: {

        },

        // especifica si será una petición POST o GET
        type: 'GET',

        // el tipo de información que se espera de respuesta
        dataType: 'json',

        // código a ejecutar si la petición es satisfactoria;
        // la respuesta es pasada como argumento a la función
        success: function (json) {
            $('#modal-section').append(`<h3>Organizadores</h3>`)
            $.each(json, (i, v) => {
                $('#modal-section').append(`${v.firstName}, `)
            })
            $('#modal-section').append(`<br>`)
        },

        // código a ejecutar si la petición falla;
        // son pasados como argumentos a la función
        // el objeto de la petición en crudo y código de estatus de la petición
        error: function (xhr, status) {
            console.log('Disculpe, hubo un error');
        },

        // código a ejecutar sin importar si la petición falló o no
        complete: function (xhr, status) {
            console.log('Petición Organizadores realizada');
        }
    });

    $.ajax({
        // la URL para la petición
        url: 'https://localhost:7216/api/Tutor/Obtener',
        // la información a enviar
        // (también es posible utilizar una cadena de datos)
        data: {

        },

        // especifica si será una petición POST o GET
        type: 'GET',

        // el tipo de información que se espera de respuesta
        dataType: 'json',

        // código a ejecutar si la petición es satisfactoria;
        // la respuesta es pasada como argumento a la función
        success: function (json) {
            $('#modal-section').append(`<h3>Tutores</h3>`)
            $.each(json, (i, v) => {
                $('#modal-section').append(`${v.firstName}, `)
            })
            $('#modal-section').append(`<br>`)

        },

        // código a ejecutar si la petición falla;
        // son pasados como argumentos a la función
        // el objeto de la petición en crudo y código de estatus de la petición
        error: function (xhr, status) {
            console.log('Disculpe, hubo un error');
        },

        // código a ejecutar sin importar si la petición falló o no
        complete: function (xhr, status) {
            console.log('Petición Tutores realizada');
        }
    });

    $.ajax({
        // la URL para la petición
        url: 'https://localhost:7216/API/Acampantes/Obtener',
        // la información a enviar
        // (también es posible utilizar una cadena de datos)
        data: {

        },

        // especifica si será una petición POST o GET
        type: 'GET',

        // el tipo de información que se espera de respuesta
        dataType: 'json',

        // código a ejecutar si la petición es satisfactoria;
        // la respuesta es pasada como argumento a la función
        success: function (json) {
            $('#modal-section').append(`<h3>Acampantes</h3>`)
            $.each(json, (i, v) => {
                $('#modal-section').append(`${v.firstName}, `)
            })
            $('#modal-section').append(`<br>`)

        },

        // código a ejecutar si la petición falla;
        // son pasados como argumentos a la función
        // el objeto de la petición en crudo y código de estatus de la petición
        error: function (xhr, status) {
            console.log('Disculpe, hubo un error');
        },

        // código a ejecutar sin importar si la petición falló o no
        complete: function (xhr, status) {
            console.log('Petición Acampantes realizada');
        }
    });

}
/*
function MostrarCredencial(){
  let v_nombre  = document.getElementById('nombre').value;
  let v_apellido  = document.getElementById('apellido').value;

  let Id_credencial = this.dataset.abrirc;
  document.getElementById(Id_credencial).classList.add('es-visiblec');
               
  $('.textocredencial').append(`<h1 id="nombrecredencial">${v_nombre} ${v_apellido}</h1>`)
  
}
*/

function NuevoRegistro() {
    console.log('Inicio Funcion')
    let Id_credencial = this.dataset.abrirc;

    validation();
    function validation() {
        let v_nombre = document.getElementById('nombre').value;
        let v_apellido = document.getElementById('apellido').value;
        let v_edad = document.getElementById('edad').value;
        let v_email = document.getElementById('email').value;
        let m = new Date();
        let v_fecha = m.getUTCFullYear() + "-" + ("0" + (m.getUTCMonth() + 1)).slice(-2) + "-" + ("0" + m.getUTCDate()).slice(-2);
        let acampante = { id: 0, firstName: v_nombre, lastName: v_apellido, age: v_edad, email: v_email, register: v_fecha }

        if (v_nombre === '' || v_apellido === '' || v_edad === '' || v_email === '') {
            alert("Completar todos los campos");

        } else {

            $.ajax({
                type: 'post',
                url: 'https://localhost:7216/API/Acampantes/Guardar',
                contentType: 'application/json',
                dataType: 'json',
                data: JSON.stringify(acampante),

                success: function (data) {
                    document.getElementById(Id_credencial).classList.add('es-visiblec');
                    $('.textocredencial').append(`<h1 id="nombrecredencial">${v_nombre} ${v_apellido}</h1>`)
                },

                error: function (xhr, status) {
                    alert('Disculpe, existió un problema');
                },

                complete: function (xhr, status) {
                    console.log('Petición realizada');
                }
            })

        }

    }


    console.log('Final de funcion')
    /*
      
    */
};