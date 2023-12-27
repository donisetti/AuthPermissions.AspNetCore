
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
        height: 'auto',
        // stickyHeaderDates: false, // for disabling

        headerToolbar: {
            left: 'prev,next today',
            center: 'title',
            right: 'listMonth,listYear'
        },

        // customize the button names,
        // otherwise they'd all just say "list"
        views: {
            listMonth: { buttonText: 'list month' },
            listYear: { buttonText: 'list year' }
        },

        initialView: 'listYear',
        initialDate: '2023-01-12',
        navLinks: true, // can click day/week names to navigate views
        editable: true,
        events: '/Agendamento/ListaEventosJSON'
        
    });

    calendar.render();
});
