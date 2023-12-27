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
            right: 'listDay,listWeek'
        },

        // customize the button names,
        // otherwise they'd all just say "list"
        views: {
            listDay: { buttonText: 'list day' },
            listWeek: { buttonText: 'list week' }
        },

        initialView: 'listWeek',
        initialDate: '2023-01-12',
        navLinks: true, // can click day/week names to navigate views
        editable: true,
        dayMaxEvents: true, // allow "more" link when too many events
        events: '/Agendamento/ListaEventosJSON'
       
    });

    calendar.render();
});
