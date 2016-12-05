$(document).ready(function () {
    $('.iCheck').iCheck({
        checkboxClass: 'icheckbox_square-green',
        radioClass: 'iradio_square-green',
        increaseArea: '20%' // optional
    });
});
























// Callback that creates and populates a data table,
// instantiates the pie chart, passes in the data and
// draws it.
//var chartDataRecomendacion;
//function drawChart() {
//    // Create the data table.
//    var data = new google.visualization.arrayToDataTable(chartDataRecomendacion);
//    //data.addColumn('string', 'Topping');
//    //data.addColumn('number', 'Slices');
//    //data.addRows([
                
//    //]);
//    // Set chart options
//    var options = {
//        'title': 'How Much Pizza I Ate Last Night',
//        'width': 400,
//        'height': 300
//    };
//    // Instantiate and draw our chart, passing in some options.
//    var chart = new google.visualization.PieChart(document.getElementById('RecomendacionChart'));
//    chart.draw(data, options);
//}
//// Load the Visualization API and the piechart package.
//google.load('visualization', '1.0', { 'packages': ['corechart'] });
//// Set a callback to run when the Google Visualization API is loaded.
////google.setOnLoadCallback(drawChart);
////cargar datos del servidor
//$(document).ready(function () {
//    $.ajax({
//        ur: "@Url.Action("CantidadAnual", "Recomendacion")",
//        data: "",
//    dataType: "json",
//    type: "GET",
//    contentType: "application/json; chartset=utf-8",
//    success: function (data) {
//        chartDataRecomendacion = data;
//    },
//    error: function () {
//        alert("Error");
//    }
//}).done(function () {
//    drawChart();
//});
//});


//function drawChart(d) {
//    var chartData = d;
//    var data = null;
//    data = google.visualization.arrayToDataTable(chartData);

//    var view = new google.visualization.DataView(data);
//    view.setColumns([0, {
//        type: 'string',
//        label: data.getColumnLabel(0),
//        calc: function () { return 0; }
//    }, {
//        type: 'number',
//        label: data.getColumnLabel(1),
//        calc: function () { return 0; }
//    }]);

//    var chart = new google.visualization.ColumnChart(document.getElementById('RecomendacionChart'));
//    var options = {
//        title: 'Recomendaciones',
//        legend: 'bottom',
//        hAxis: {
//            title: 'Meses'
//        },
//        vAxis: {
//            title: 'Cantidad',
//            minValue: 0,
//            maxValue: 1000000
//        },
//        chartArea: {
//            width: 600,
//            height: 400
//        },
//        animation: {
//            duration: 1000
//        }
//    };

//    var runFirstTime = google.visualization.events.addListener(chart, 'ready', function () {
//        google.visualization.events.removeListener(runFirstTime);
//        chart.draw(data, options);
//    });

//    chart.draw(view, options);
//}
