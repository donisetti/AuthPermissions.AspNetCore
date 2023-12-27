
document.addEventListener('DOMContentLoaded', function () {
    var calendarEl = document.getElementById('calendar');

    var calendar = new FullCalendar.Calendar(calendarEl, {
        locale: 'pt-br',
        buttonText: {
            today: 'Hoje',
            month: 'Mês',
            week: 'Semana',
            day: 'Dia',
            list: 'Lista'
        },
        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay'
        },
        //initialDate: '2023-01-12',
        navLinks: true, // can click day/week names to navigate views
        selectable: true,
        selectMirror: true,

        editable: true,
        dayMaxEvents: true, // allow "more" link when too many events
        //defaultView: 'agendaWeek', // Defina a visualização padrão para a semana de agenda
        slotDuration: '00:15:00', // Define o intervalo de tempo para os slots (30 minutos)
        businessHours: {
            // Define as horas comerciais (08:00 às 18:00) de segunda a sexta-feira
            dow: [1, 2, 3, 4, 5], // dias da semana (1 = segunda-feira, 2 = terça-feira, etc.)

            start: '08:00', // hora de início das horas comerciais
            end: '18:00' // hora de término das horas comerciais
        },

        events: '/Agendamento/GetEventos',

        //eventDidMount: function (info) {
        //    var eventObj = info.event;
        //    var exteventObj = info.event.extendedProps;

        //    var texto = exteventObj.cliente.nome + ' ->' + exteventObj.funcionario.nome;

        //    console.log(texto);

        //    var tooltip = new Tooltip(info.el, {
        //        title: texto,
        //        placement: 'top',
        //        trigger: 'hover',
        //        container: 'body'
        //    });
        //},

        eventClick: function (info) {
            var eventObj = info.event;
            var exteventObj = info.event.extendedProps;
            var dataInicio = eventObj.start.toLocaleString('pt-BR', { timezone: 'UTC' });
            var dataTermino = eventObj.end.toLocaleString('pt-BR', { timezone: 'UTC' });
            console.log(eventObj);
           
            $('#form-modal #eventTitle').text(eventObj.title);

            var $description = $('<div/ class="alert alert-secondary" role="alert" style="margin-top:3px">');

            $description.append($('<p/ class="alert alert-primary" role="alert">').html('<b>Cliente:</b> ' + exteventObj.cliente.nome));

            $description.append($('<p/ class="alert alert-primary" role="alert">').html('<b>Funcionário::</b> ' + exteventObj.funcionario.nome));




            $description.append($('<p/ class="alert alert-primary" role="alert">').html('<b>Data Início:</b> ' + dataInicio));

            if (eventObj.end != null) {
                $description.append($('<p/ class="alert alert-primary" role="alert">').html('<b>Data Término:</b> ' + dataTermino));
            }

            $description.append($('<p/ class="alert alert-primary" role="alert">').html('<b>Atividade:</b> ' + eventObj.title));

            $('#form-modal #pDetails').empty().html($description);

            $('#form-modal').modal('show');

            $('#btnEdit').click(function () {
                //Redirect for edit event

                window.location = '/Agendamento/Alterar/'  + eventObj.id;
            });

            $('#btnDelete').click(function () {
                //Redirect for edit event

                window.location = '/Agendamento/Delete/' + eventObj.id;
            });

        },
       
        dateClick: function (info, jsEvent, view) {
            //let m = moment(info.date, calendar); // calendar is required
            //console.log('clicked on ' + m.format())
            const dataAtual = Date.now();
            const agora = dataAtual.toLocaleString('pt-BR')
          

            let m = info.date.toLocaleString('pt-BR', { timezone: 'auto' });
            console.log(m);

            var heading = 'Confirmar nova consulta';
            var question = 'Confirme que pretende criar uma consulta';
            var cancelButtonTxt = 'Cancelar';
            var okButtonTxt = 'Confirmar';
            var callback = function () {
                window.location = '/Agendamento/Novo/' + '?eventDate=' + m;
            };

            if (info.view.type != 'month') {

                console.log(info.date);
                if (info.date > new Date()) {
                    if (confirm(heading, question, cancelButtonTxt, okButtonTxt, callback)) {
                        
                        window.location = '/Agendamento/Create/' + '?eventDate=' + m;
                    }

                }
            }
            else {
                $('#calendar').fullCalendar('changeView', 'agendaDay');
                $('#calendar').fullCalendar('gotoDate', date);
            }
        },

    });

    calendar.render();
});



/*Mascara para o campo data e hora*/
function DataHora(evento, objeto) {
    var keypress = (window.event) ? event.keyCode : evento.which;
    campo = eval(objeto);
    if (campo.value == '00/00/0000 00:00:00') {
        campo.value = "";
    }

    caracteres = '0123456789';
    separacao1 = '/';
    separacao2 = ' ';
    separacao3 = ':';
    conjunto1 = 2;
    conjunto2 = 5;
    conjunto3 = 10;
    conjunto4 = 13;
    conjunto5 = 16;
    if ((caracteres.search(String.fromCharCode(keypress)) != -1) && campo.value.length < (19)) {
        if (campo.value.length == conjunto1)
            campo.value = campo.value + separacao1;
        else if (campo.value.length == conjunto2)
            campo.value = campo.value + separacao1;
        else if (campo.value.length == conjunto3)
            campo.value = campo.value + separacao2;
        else if (campo.value.length == conjunto4)
            campo.value = campo.value + separacao3;
        else if (campo.value.length == conjunto5)
            campo.value = campo.value + separacao3;
    } else {
        event.returnValue = false;
    }
}

//$('.btn-canc-vis').on("click", function () {
//    $('.visevent').slideToggle();
//    $('.formedit').slideToggle();
//});

//$('.btn-canc-edit').on("click", function () {
//    $('.formedit').slideToggle();
//    $('.visevent').slideToggle();
//});

//$("#editevent").on("submit", function (event) {
//    event.preventDefault();
//    $.ajax({
//        method: "POST",
//        url: "/Agendamento/Edit",
//        data: new FormData(this),
//        contentType: false,
//        processData: false,
//        success: function (retorna) {
//            if (retorna['sit']) {
//                //$("#msg-cad").html(retorna['msg']);
//                location.reload();
//            } else {
//                $("#msg-edit").html(retorna['msg']);
//            }
//        }
//    })
//});

function editar() {
    $(".visevent").slideToggle();
    $(".formedit").slideToggle();
}

function cancelar() {
    $(".formedit").slideToggle();
    $(".visevent").slideToggle();
}

function alterar() {

    let formulario = $("#editevent").serialize();

    $.ajax({
        url: '/Agendamento/Edit',
        type: 'POST',
        data: formulario,
        dataType: 'json'
    }).done(function (resposta) {
        win.location.href = "/Agendamento/Agenda"

        if (resposta.status) {
            console.log(resposta);
            alert(resposta)

            setTimeout(function () {
                location.reload();
            }, 1000);
        }
    })



}