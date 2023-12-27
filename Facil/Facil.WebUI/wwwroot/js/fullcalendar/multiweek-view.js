
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
            right: 'dayGridYear,dayGridMonth,timeGridWeek'
        },
        initialView: 'dayGridYear',
        initialDate: '2023-01-12',
        editable: true,
        selectable: true,
        dayMaxEvents: true, // allow "more" link when too many events
        // businessHours: true,
        // weekends: false,
        events: '/Agendamento/ListaEventosJSON'
      
    });

    calendar.render();
});
