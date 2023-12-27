
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
        initialDate: '2023-01-12',
        initialView: 'timeGridWeek',
        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'dayGridMonth,timeGridWeek,timeGridDay,listWeek'
        },
        height: 'auto',
        navLinks: true, // can click day/week names to navigate views
        editable: true,
        selectable: true,
        selectMirror: true,
        nowIndicator: true,
        events: '/Agendamento/ListaEventosJSON'
    
    });

    calendar.render();
});
