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
        // la URL para la petici�n
        url: 'https://localhost:7216/API/Acampantes/Obtener',

        // la informaci�n a enviar
        // (tambi�n es posible utilizar una cadena de datos)
        data: {

        },

        // especifica si ser� una petici�n POST o GET
        type: 'GET',

        // el tipo de informaci�n que se espera de respuesta
        dataType: 'json',

        // c�digo a ejecutar si la petici�n es satisfactoria;
        // la respuesta es pasada como argumento a la funci�n
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

        // c�digo a ejecutar si la petici�n falla;
        // son pasados como argumentos a la funci�n
        // el objeto de la petici�n en crudo y c�digo de estatus de la petici�n
        error: function (xhr, status) {
            console.log('Disculpe, hubo un error');
        },

        // c�digo a ejecutar sin importar si la petici�n fall� o no
        complete: function (xhr, status) {
            console.log('Petici�n llamar acampantes realizada');
        }
    });
}


function VerParticipantes() {

    let Id_modal = this.dataset.abrir;
    document.getElementById(Id_modal).classList.add('es-visible');

    $.ajax({
        // la URL para la petici�n
        url: 'https://localhost:7216/api/Organizador/Obtener',
        // la informaci�n a enviar
        // (tambi�n es posible utilizar una cadena de datos)
        data: {

        },

        // especifica si ser� una petici�n POST o GET
        type: 'GET',

        // el tipo de informaci�n que se espera de respuesta
        dataType: 'json',

        // c�digo a ejecutar si la petici�n es satisfactoria;
        // la respuesta es pasada como argumento a la funci�n
        success: function (json) {
            $('#modal-section').append(`<h3>Organizadores</h3>`)
            $.each(json, (i, v) => {
                $('#modal-section').append(`${v.firstName}, `)
            })
            $('#modal-section').append(`<br>`)
        },

        // c�digo a ejecutar si la petici�n falla;
        // son pasados como argumentos a la funci�n
        // el objeto de la petici�n en crudo y c�digo de estatus de la petici�n
        error: function (xhr, status) {
            console.log('Disculpe, hubo un error');
        },

        // c�digo a ejecutar sin importar si la petici�n fall� o no
        complete: function (xhr, status) {
            console.log('Petici�n Organizadores realizada');
        }
    });

    $.ajax({
        // la URL para la petici�n
        url: 'https://localhost:7216/api/Tutor/Obtener',
        // la informaci�n a enviar
        // (tambi�n es posible utilizar una cadena de datos)
        data: {

        },

        // especifica si ser� una petici�n POST o GET
        type: 'GET',

        // el tipo de informaci�n que se espera de respuesta
        dataType: 'json',

        // c�digo a ejecutar si la petici�n es satisfactoria;
        // la respuesta es pasada como argumento a la funci�n
        success: function (json) {
            $('#modal-section').append(`<h3>Tutores</h3>`)
            $.each(json, (i, v) => {
                $('#modal-section').append(`${v.firstName}, `)
            })
            $('#modal-section').append(`<br>`)

        },

        // c�digo a ejecutar si la petici�n falla;
        // son pasados como argumentos a la funci�n
        // el objeto de la petici�n en crudo y c�digo de estatus de la petici�n
        error: function (xhr, status) {
            console.log('Disculpe, hubo un error');
        },

        // c�digo a ejecutar sin importar si la petici�n fall� o no
        complete: function (xhr, status) {
            console.log('Petici�n Tutores realizada');
        }
    });

    $.ajax({
        // la URL para la petici�n
        url: 'https://localhost:7216/API/Acampantes/Obtener',
        // la informaci�n a enviar
        // (tambi�n es posible utilizar una cadena de datos)
        data: {

        },

        // especifica si ser� una petici�n POST o GET
        type: 'GET',

        // el tipo de informaci�n que se espera de respuesta
        dataType: 'json',

        // c�digo a ejecutar si la petici�n es satisfactoria;
        // la respuesta es pasada como argumento a la funci�n
        success: function (json) {
            $('#modal-section').append(`<h3>Acampantes</h3>`)
            $.each(json, (i, v) => {
                $('#modal-section').append(`${v.firstName}, `)
            })
            $('#modal-section').append(`<br>`)

        },

        // c�digo a ejecutar si la petici�n falla;
        // son pasados como argumentos a la funci�n
        // el objeto de la petici�n en crudo y c�digo de estatus de la petici�n
        error: function (xhr, status) {
            console.log('Disculpe, hubo un error');
        },

        // c�digo a ejecutar sin importar si la petici�n fall� o no
        complete: function (xhr, status) {
            console.log('Petici�n Acampantes realizada');
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
                    alert('Disculpe, existi� un problema');
                },

                complete: function (xhr, status) {
                    console.log('Petici�n realizada');
                }
            })

        }

    }


    console.log('Final de funcion')
    /*
      
    */
};