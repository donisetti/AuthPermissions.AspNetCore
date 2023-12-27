
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
        editable: true,
        selectable: true,
        businessHours: true,
        dayMaxEvents: true, // allow "more" link when too many events
        events: '/Agendamento/ListaEventosJSON'
      
    });

    calendar.render();
});
