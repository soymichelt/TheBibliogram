@Code
    ViewData("Title") = "Préstamos por Departamento"
    Layout = "~/Views/Shared/_AdministratorLayout.vbhtml"
End Code
@Styles.Render("~/Content/icheckcolor")

<!-- Content Header (Page header) -->
<section class="content-header">
    <h1>Estadísticas
<small>Prestamos de bibliográfia por departamento</small>
    </h1>
    <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i>Administrador</a></li>
        <li class="active">Prestamo por Departamento</li>
    </ol>
</section>

<!-- Main content -->
<section class="content">
    @* GRAFICO DE RECOMENDACIONES *@
    <div class="row">
        <div class="col-md-12">
            <div class="box box-success">
                <div class="box-header with-border">
                    <h3 class="box-title"><span class="ion ion-funnel"></span>&nbsp;&nbsp;Filtros</h3>
                    <div class="box-tools pull-right">
                        <button id="btnLoadReport" class="btn btn-default btn-sm"><i class="ion ion-android-checkmark-circle"></i></button>
                    </div>
                    <!-- /.box-tools -->
                </div>
                <div class="box-body">
                    <div class="col-md-12">
                        <form id="FormParametros">
                            <div class="row">
                                <div class="col-sm-12 col-md-4">
                                    <div class="input-group has-success">
                                        <label for="Anual" class="input-group-addon input-title-theme">Año</label>
                                        <input type="number" class="form-control" id="Anual" name="Anual" placeholder="Año del Reporte" value="@DateTime.Now.Year" required>
                                    </div>
                                </div>
                                <div class="dividerx40 visible-sm"></div>
                                <div class="dividerx10 visible-xs"></div>
                                <div class="col-sm-12 col-md-4">
                                    <div class="input-group has-success">
                                        <label for="Modalidad" class="input-group-addon input-title-theme">Módulo</label>
                                        <select id="Modalidad" name="Modalidad" class="form-control" required>
                                            @For Each c In AppWeb.Globales.Modalidad()
                                                @<option value="@c.N">@c.Nombre</option>
                                            Next
                                        </select>
                                    </div>
                                </div>
                                <div class="dividerx40 visible-sm"></div>
                                <div class="dividerx10 visible-xs"></div>
                                <div class="col-sm-12 col-md-4">
                                    <div class="input-group has-success">
                                        <label for="Departamento" class="input-group-addon input-title-theme">Dpto.</label>
                                        <select id="Departamento" name="Departamento" class="form-control" required>
                                            <option class="opt-theme" value=""></option>
                                            <option class="opt-theme" value="1">Ciencias, Tecnología y Salud</option>
                                            <option class="opt-theme" value="2">Económicas y Administrativas</option>
                                            <option class="opt-theme" value="3">Educación y Humanidades</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div class="dividerx10"></div>
                        </form>
                    </div>
                </div>
            </div>         
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="box box-success">
                <div class="box-header with-border">
                    <h3 class="box-title"><span class="ion ion-pie-graph"></span>&nbsp;&nbsp;Gráfica</h3>
                    <div class="box-tools pull-right">
                        <button class="btn btn-box-tool"><i class="ion ion-android-refresh"></i></button>
                    </div>
                    <!-- /.box-tools -->
                </div>
                <!-- /.box-header -->
                <div class="box-body">
                    <div class="col-md-12">
                        <p class="text-center">
                            <strong id="RangoFecha"></strong>
                        </p>
                        <div Id="RecomendacionChart">
                            <canvas id="GraficoResultado" style="width: 100%; height: 400px;"></canvas>
                        </div>
                        <!-- /.chart-responsive -->
                    </div>
                </div>
                <!-- /.box-body -->
                @*<div class="box-footer">
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
                </div>*@
            </div>
            <!-- /.box -->
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="box box-success">
                <div class="box-header with-border">
                    <h3 class="box-title"><span class="ion ion-ios-briefcase"></span>&nbsp;&nbsp;Resultados</h3>
                    <div class="box-tools pull-right">
                        <button class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-plus"></i></button>
                    </div>
                    <!-- /.box-tools -->
                </div>
                <!-- /.box-header -->
                <div class="box-body no-padding">
                    <div class="row">
                        <div class="col-xs-12">
                            <div class="table-responsive">
                                <table class="table table-striped">
                                    <thead>
                                        <tr>
                                            <td>
                                                Mes
                                            </td>
                                            <td>
                                                Hombre
                                            </td>
                                            <td>
                                                Mujer
                                            </td>
                                            <td>
                                                Total
                                            </td>
                                        </tr>
                                    </thead>
                                    <tbody id="TablaResultado">
                                        
                                    </tbody>
                                    <tfoot>
                                        <tr>
                                            <td>
                                                Mes
                                            </td>
                                            <td>
                                                Hombre
                                            </td>
                                            <td>
                                                Mujer
                                            </td>
                                            <td>
                                                Total
                                            </td>
                                        </tr>
                                    </tfoot>
                                </table>
                            </div>
                        </div>
                    </div>
                    <!-- /.row -->
                </div>
                <!-- /.box-body -->
            </div>
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
@* Modal para mensajes *@
<div id="MensajeModal" class="modal fade modal-success">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                <h2 class="modal-title"><span class="glyphicon glyphicon-exclamation-sign"></span>&nbsp;&nbsp;<span class="text-center">Mensaje del Sistema</span></h2>
            </div>
            <div class="modal-body">
                <p id="Mensaje">

                </p>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-outline pull-left" data-dismiss="modal"><span class="glyphicon glyphicon-remove-circle"></span>&nbsp;&nbsp;Cerrar</button>
                <a href="@Url.Action("Ayuda", "Informacion")" target="_blank" class="btn btn-outline"><span class="glyphicon glyphicon-question-sign"></span>&nbsp;&nbsp;Solicita Ayuda</a>
            </div>
        </div>
        <!-- /.modal-content -->
    </div>
    <!-- /.modal-dialog -->
</div>
<!-- /.content -->
@Section Scripts
    @Scripts.Render("~/bundles/ChartJS")
    <script type="text/javascript">
        $(document).ready(function () {
            $("#btnLoadReport").click(function (e) {
                e.preventDefault();
                var Resultados = null;
                var Anual = $("#Anual").val();
                var Modalidad = $("#Modalidad").val();
                var ModDescrip = $("#Modalidad option:selected").text();
                var Departamento = $("#Departamento").val();
                var DepDescrip = $("#Departamento option:selected").text();
                if ((Anual + "").trim() == "" || (Modalidad + "").trim() == "" || (Departamento + "").trim() == "") {
                    Mensaje("<h3>Ingresar todos los parámetros</h3>Es necesario que ingrese todos los parámetros para poder cargar la información de los gráficos.");
                }
                $.ajax({
                    url: '@Url.Action("TablaResultados", "PrestamoFondoBibliografico")',
                type: 'GET',
                dataType: 'json',
                data: "Anual=" + Anual + "&Modalidad=" + Modalidad + "&Departamento=" + Departamento,
                success: function (data) {
                    Resultados = data;
                },
                error: function () {
                    Mensaje("<h3>!Ups¡ Error, Lo sentimos</h3>Error al obtener datos del servidor intente mas tarde. Verifique su conexión a Internet. Si el problema persiste contactese con el administrador.");
                },
                }).done(function () {
                    $("#RangoFecha").html("<span style='color:#4285f4;'>Año: " + Anual + "</span>&nbsp;&nbsp;&nbsp;<span style='color:#ea4335;'>Modalidad: " + ModDescrip + "</span>&nbsp;&nbsp;&nbsp;<span style='color:#fbbc05'>Departamento: " + DepDescrip + "</span>");
                    drawTableResultadosPrestamoDepartamento(Resultados);
                    drawChartResultadosPrestamoDepartamento(Resultados);
                });
            });
            var chartData = null;
        });

        function Mensaje(mensaje) {
            $("#Mensaje").html(mensaje);
            $("#MensajeModal").modal("show");
        }

        function drawTableResultadosPrestamoDepartamento(Tabla) {
            var TablaHTML = "";
            $.each(Tabla, function (i, item) {
                TablaHTML = TablaHTML + "<tr>";
                for (var j = 0; j < item.length; j++) {
                    //texto = texto + item[j] + ";";
                    TablaHTML = TablaHTML + "<td>" + item[j] + "</td>";
                }
                TablaHTML = TablaHTML + "</tr>";
            });
            $("#TablaResultado").html(TablaHTML);
        }

        var labels = []; var C1 = []; var C2 = []; var C3 = [];
        var CantidadDatos = 0;
        var LineChart = {
            labels: labels,
            datasets: [{
                label: "Total",
                fillColor: "rgba(163, 190, 140, 1)",
                strokeColor: "rgba(255,255,255,1)",
                pointColor: "rgba(220,220,220,1)",
                pointStrokeColor: "#fff",
                data: C3
            }, {
                label: "Mujeres",
                fillColor: "rgba(91, 144, 191, 1)",
                strokeColor: "rgba(255,255,255,1)",
                pointColor: "rgba(220,220,220,1)",
                pointStrokeColor: "#fff",
                data: C2
            }, {
                label: "Hombes",
                fillColor: "rgba(208, 135, 112, 1)",
                strokeColor: "rgba(255,255,255,1)",
                pointColor: "rgba(220,220,220,1)",
                pointStrokeColor: "#fff",
                data: C1
            }]
        };
        var Grafico = new Chart(document.getElementById("GraficoResultado").getContext("2d")).Line(LineChart, { scaleFontSize: 13, scaleFontColor: "#808080", responsive: true });
        
        function drawChartResultadosPrestamoDepartamento(Tabla) {
            
            for (var i = 0; i < this.CantidadDatos; i++) {
                Grafico.removeData();
                console.log(i);
            }
            CantidadDatos = 0;
            
            $.each(Tabla, function (i, item) {
                CantidadDatos = CantidadDatos + 1;
                Grafico.addData([item[3], item[2], item[1]], item[0]);
            });
        }
    </script>
End Section