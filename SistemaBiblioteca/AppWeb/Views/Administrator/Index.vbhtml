@Code
    ViewData("Title") = "Dashboard"
    Layout = "~/Views/Shared/_AdministratorLayout.vbhtml"
End Code

<!-- Content Header (Page header) -->
<section class="content-header">
    <h1>Dashboard
<small>Panel de Control del Administrador</small>
    </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Administrador</a></li>
        <li class="active">Dashboard</li>
    </ol>
</section>

<!-- Main content -->
<section class="content">
    <div class="row">
        <div class="col-lg-3 col-xs-6">
            <!-- small box -->
            <div class="small-box bg-aqua">
                <div class="inner">
                    <h3>150</h3>
                    <p>Recomendaciones</p>
                </div>
                <div class="icon">
                    <i class="ion ion-ios-bookmarks"></i>
                </div>
                <a href="#" class="small-box-footer">Detalle <i class="fa fa-arrow-circle-right"></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <!-- small box -->
            <div class="small-box bg-green">
                <div class="inner">
                    <h3>53<sup style="font-size: 20px">%</sup></h3>
                    <p>Libros Buscados</p>
                </div>
                <div class="icon">
                    <i class="ion ion-stats-bars"></i>
                </div>
                <a href="#" class="small-box-footer">Detalle <i class="fa fa-arrow-circle-right"></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <!-- small box -->
            <div class="small-box bg-yellow">
                <div class="inner">
                    <h3>44</h3>
                    <p>Registrados</p>
                </div>
                <div class="icon">
                    <i class="ion ion-person-add"></i>
                </div>
                <a href="#" class="small-box-footer">Detalle <i class="fa fa-arrow-circle-right"></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class="col-lg-3 col-xs-6">
            <!-- small box -->
            <div class="small-box bg-red">
                <div class="inner">
                    <h3>65</h3>
                    <p>Nº de Visitas</p>
                </div>
                <div class="icon">
                    <i class="ion ion-pie-graph"></i>
                </div>
                <a href="#" class="small-box-footer">Detalle <i class="fa fa-arrow-circle-right"></i></a>
            </div>
        </div>
        <!-- ./col -->
    </div>
    @* GRAFICO DE RECOMENDACIONES *@
    <div class="row">
        <div class="col-md-12">
            <div class="box box-success">
                <div class="box-header with-border">
                    <h3 class="box-title">Recomendaciones</h3>
                    <div class="box-tools pull-right">
                        <i class="fa fa-book"></i>
                    </div>
                    <!-- /.box-tools -->
                </div>
                <!-- /.box-header -->
                <div class="box-body">
                    <div class="col-md-8">
                        <p class="text-center">
                            <strong>Cantidad: 1 Ene, 2015 - 31 Dic, 2015</strong>
                        </p>
                        <div Id="RecomendacionChart" style="width:800px; height:300px;">
                            
                        </div>
                        <!-- /.chart-responsive -->
                    </div>
                    <div class="col-md-4">
                        <p class="text-center">
                            <strong>Estadísticas</strong>
                        </p>
                        <div class="row">
                            
                        </div>
                    </div>
                </div>
                <!-- /.box-body -->
                <div class="box-footer">
                    <div class="row">
                        <div class="col-sm-3 col-xs-6">
                            <div class="description-block border-right">
                                <span class="description-percentage text-green"><i class="fa fa-caret-up"></i>17%</span>
                                <h5 class="description-header">$35,210.43</h5>
                                <span class="description-text">TOTAL REVENUE</span>
                            </div>
                            <!-- /.description-block -->
                        </div>
                        <!-- /.col -->
                        <div class="col-sm-3 col-xs-6">
                            <div class="description-block border-right">
                                <span class="description-percentage text-yellow"><i class="fa fa-caret-left"></i>0%</span>
                                <h5 class="description-header">$10,390.90</h5>
                                <span class="description-text">TOTAL COST</span>
                            </div>
                            <!-- /.description-block -->
                        </div>
                        <!-- /.col -->
                        <div class="col-sm-3 col-xs-6">
                            <div class="description-block border-right">
                                <span class="description-percentage text-green"><i class="fa fa-caret-up"></i>20%</span>
                                <h5 class="description-header">$24,813.53</h5>
                                <span class="description-text">TOTAL PROFIT</span>
                            </div>
                            <!-- /.description-block -->
                        </div>
                        <!-- /.col -->
                        <div class="col-sm-3 col-xs-6">
                            <div class="description-block">
                                <span class="description-percentage text-red"><i class="fa fa-caret-down"></i>18%</span>
                                <h5 class="description-header">1200</h5>
                                <span class="description-text">GOAL COMPLETIONS</span>
                            </div>
                            <!-- /.description-block -->
                        </div>
                    </div>
                    <!-- /.row -->
                </div>
            </div>
            <!-- /.box -->
        </div>
    </div>
    @* GRAFICO DE VISITAS *@
    <div class="row">
        <div class="col-lg-8">
            <div class="nav-tabs-custom" @*style="cursor: move;"*@>
                <!-- Tabs within a box -->
                <ul class="nav nav-tabs pull-right ui-sortable-handle">
                    <li class="active"><a href="#Visitas-chart" data-toggle="tab">Visitas</a></li>
                    <li><a href="#Sesiones-chart" data-toggle="tab">Sesiones</a></li>
                    <li class="pull-left header"><i class="fa fa-inbox"></i> Tráfico</li>
                </ul>
                <div class="tab-content no-padding">
                    <!-- Morris chart - Sales -->
                    <div class="chart tab-pane active" id="Visitas-chart" style="position: relative; height: 360px; -webkit-tap-highlight-color: rgba(0, 0, 0, 0);">
                        <div class="row">
                            <div class="col-md-9">
                                <div id="VisitasChart">

                                </div>
                            </div>
                            <div class="col-md-3">
                                <div class="pad box-pane-right bg-green" style="min-height: 280px">
                                    <div class="description-block margin-bottom">
                                        <div class="sparkbar pad" data-color="#fff">
                                            <canvas width="34" height="30" style="display: inline-block; width: 34px; height: 30px; vertical-align: top;"></canvas>
                                        </div>
                                        <h5 class="description-header">8390</h5>
                                        <span class="description-text">Mayor</span>
                                    </div>
                                    <!-- /.description-block -->
                                    <div class="description-block margin-bottom">
                                        <div class="sparkbar pad" data-color="#fff">
                                            <canvas width="34" height="30" style="display: inline-block; width: 34px; height: 30px; vertical-align: top;"></canvas>
                                        </div>
                                        <h5 class="description-header">30%</h5>
                                        <span class="description-text">Menor</span>
                                    </div>
                                    <!-- /.description-block -->
                                    <div class="description-block">
                                        <div class="sparkbar pad" data-color="#fff">
                                            <canvas width="34" height="30" style="display: inline-block; width: 34px; height: 30px; vertical-align: top;"></canvas>
                                        </div>
                                        <h5 class="description-header">70%</h5>
                                        <span class="description-text">Total</span>
                                    </div>
                                    <!-- /.description-block -->
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="chart tab-pane" id="Sesiones-chart" style="position: relative; height: 360px;">
                        <div class="row">
                            <div class="col-md-9">
                                <div id="SesionesChart" style="">

                                </div>
                            </div>
                            <div class="col-md-3">
                                <div class="pad box-pane-right bg-green" style="min-height: 280px">
                                    <div class="description-block margin-bottom">
                                        <div class="sparkbar pad" data-color="#fff">
                                            <canvas width="34" height="30" style="display: inline-block; width: 34px; height: 30px; vertical-align: top;"></canvas>
                                        </div>
                                        <h5 class="description-header">8390</h5>
                                        <span class="description-text">Mayor</span>
                                    </div>
                                    <!-- /.description-block -->
                                    <div class="description-block margin-bottom">
                                        <div class="sparkbar pad" data-color="#fff">
                                            <canvas width="34" height="30" style="display: inline-block; width: 34px; height: 30px; vertical-align: top;"></canvas>
                                        </div>
                                        <h5 class="description-header">30%</h5>
                                        <span class="description-text">Menor</span>
                                    </div>
                                    <!-- /.description-block -->
                                    <div class="description-block">
                                        <div class="sparkbar pad" data-color="#fff">
                                            <canvas width="34" height="30" style="display: inline-block; width: 34px; height: 30px; vertical-align: top;"></canvas>
                                        </div>
                                        <h5 class="description-header">70%</h5>
                                        <span class="description-text">Total</span>
                                    </div>
                                    <!-- /.description-block -->
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <!-- Info Boxes Style 2 -->
            <div class="info-box bg-yellow">
                <span class="info-box-icon"><i class="ion ion-ios-pricetag-outline"></i></span>
                <div class="info-box-content">
                    <span class="info-box-text">Nº de Títulos</span>
                    <span class="info-box-number">5,200</span>
                    <div class="progress">
                        <div class="progress-bar" style="width: 80%"></div>
                    </div>
                    <span class="progress-description">50% Increase in 30 Days
                    </span>
                </div>
                <!-- /.info-box-content -->
            </div>
            <!-- /.info-box -->
            <div class="info-box bg-green">
                <span class="info-box-icon"><i class="ion ion-ios-heart-outline"></i></span>
                <div class="info-box-content">
                    <span class="info-box-text">Nº de Volumenes</span>
                    <span class="info-box-number">92,050</span>
                    <div class="progress">
                        <div class="progress-bar" style="width: 80%"></div>
                    </div>
                    <span class="progress-description">20% Increase in 30 Days
                    </span>
                </div>
                <!-- /.info-box-content -->
            </div>
            <!-- /.info-box -->
            <div class="info-box bg-red">
                <span class="info-box-icon"><i class="ion ion-ios-cloud-download-outline"></i></span>
                <div class="info-box-content">
                    <span class="info-box-text">Estaciones Virtuales</span>
                    <span class="info-box-number">114,381</span>
                    <div class="progress">
                        <div class="progress-bar" style="width: 80%"></div>
                    </div>
                    <span class="progress-description">70% Increase in 30 Days
                    </span>
                </div>
                <!-- /.info-box-content -->
            </div>
            <!-- /.info-box -->
            <div class="info-box bg-aqua">
                <span class="info-box-icon"><i class="ion-ios-chatbubble-outline"></i></span>
                <div class="info-box-content">
                    <span class="info-box-text"></span>
                    <span class="info-box-number">163,921</span>
                    <div class="progress">
                        <div class="progress-bar" style="width: 80%"></div>
                    </div>
                    <span class="progress-description">40% Increase in 30 Days
                    </span>
                </div>
                <!-- /.info-box-content -->
            </div>
            <!-- /.box -->
        </div>
    </div>
</section>
<!-- /.content -->
@Section Scripts
    <script type="text/javascript" src="https://www.google.com/jsapi"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            var chartData = null;
            //char recomendacion
            $.ajax({
                url: '@Url.Action("CantidadAnual", "Recomendacion")',
                type: 'GET',
                dataType: 'json',
                data: '',
                success: function (data) {
                    chartData = data;
                },
                error: function () {
                    alert('Error!!.');
                },
            }).done(function () {
                drawChart(chartData, "RecomendacionChart", 1);
            });

            //char visitas
            $.ajax({
                url: '@Url.Action("CantidadAnual", "Recomendacion")',
                type: 'GET',
                dataType: 'json',
                data: '',
                success: function (data) {
                    chartData = data;
                },
                error: function () {
                    alert('Error!!.');
                },
            }).done(function () {
                drawChart(chartData, "VisitasChart", 2);
            });

            //char sesiones
            $.ajax({
                url: '@Url.Action("CantidadAnual", "Recomendacion")',
                type: 'GET',
                dataType: 'json',
                data: '',
                success: function (data) {
                    chartData = data;
                },
                error: function () {
                    alert('Error!!.');
                },
            }).done(function () {
                drawChart(chartData, "SesionesChart", 2);
            });
        });

        function drawChart(d, AreaName, TypeChart) {
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'Meses');
            data.addColumn('number', 'Cantidad');
            $.each(d, function (i, item) {
                data.addRows([
                    item
                ]);
            });
            var options = {
                pointSize: 7,
                legend: 'bottom',
                chartArea: { top: 0, left: 20 },
                hAxis: { title: 'Meses' },
                vAxis: { minValue: 0 },
                animation: { duration: 1000 }
            };
            if (TypeChart == 1) {
                var chart = new google.visualization.AreaChart(document.getElementById(AreaName));
                chart.draw(data, options);
            } else if (TypeChart == 2) {
                var chart = new google.visualization.PieChart(document.getElementById(AreaName));
                chart.draw(data, options);
            } else if (TypeChart == 3) {
                var chart = new google.visualization.ColumnChart(document.getElementById(AreaName));
                chart.draw(data, options);
            } else if (TypeChart == 4) {
                var chart = new google.visualization.BarChart(document.getElementById(AreaName));
                chart.draw(data, options);
            }
        }
        
        google.load('visualization', '1.0', { 'packages': ['corechart'] });
    </script>
End Section