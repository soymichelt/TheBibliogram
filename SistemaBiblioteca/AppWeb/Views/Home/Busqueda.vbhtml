@ModelType List(Of AppWeb.LibroServicio.DLibro)

@Code
    ViewData("Title") = "Busqueda"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
@Styles.Render("~/Content/selectbscss")
<div class="col-sm-12 col-md-6">
    @Using Html.BeginForm("Busqueda", "Home", New With {.ReturnUrl = ViewData("ReturnUrl")}, FormMethod.Get)
        @Html.ValidationSummary(True)
        @<div class="publicacion-theme">
            <div class="panel-estado-heading-theme">
                <span class="text-left">
                    Búsquedas del fondo bibliográfico
                </span>
                <span class="pull-right">
                    <span class="glyphicon glyphicon-search  icon-perfil"></span>
                </span>
            </div>
            <div class="panel-estado-theme">
                <div class="">
                    <label for="Titulo" class="sr-only">Titulo</label>
                    <div class="inner-addon left-addon">
                        <i class="glyphicon glyphicon-file"></i>
                        <input type="text" name="_Titulo" id="Titulo" class="form-control input-theme" placeholder="Título del fondo bibliográfico" autofocus="">
                    </div>
                    <div class="dividerx10"></div>
                    <div class="row">
                        <div class="col-xs-12 col-sm-6">
                            <label for="Autor" class="sr-only">Autor</label>
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-user"></i>
                                <input type="text" name="_Autor" id="Autor" class="form-control input-theme" placeholder="Autor personal">
                            </div>
                        </div>
                        <div class="dividerx10 visible-xs"></div>
                        <div class="col-xs-12 col-sm-6">
                            <label for="Institucion" class="sr-only">Institución</label>
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-user"></i>
                                <input type="text" name="_Institucion" id="Institucion" class="form-control input-theme" placeholder="Institución">
                            </div>
                        </div>
                    </div>
                    <div class="dividerx10"></div>
                    <div class="row">
                        <div class="col-xs-12 col-sm-6">
                            <label for="inputPassword" class="sr-only">Tipo de Doc.</label>
                            <div class="input-group">
                                <span class="input-group-addon">TD</span>
                                <select class="form-control" name="_TipoDocumento" id="tipodocumento">
                                    <option value=""></option>
                                    <option value="Colec">Colec</option>
                                    <option value="Medic">Medic</option>
                                    <option value="Monog">Monog</option>
                                    <option value="Autor">Autor</option>
                                    <option value="Refer">Refer</option>
                                    <option value="Extrj">Extrj</option>
                                </select>
                            </div>
                        </div>
                        <div class="dividerx10 visible-xs"></div>
                        <div class="col-xs-12 col-sm-6">
                            <label for="inputPassword" class="sr-only">Tipo de Reg.</label>
                            <div class="input-group">
                                <span class="input-group-addon">TR</span>
                                <select class="form-control" name="_TipoRegistro" id="tiporegistro">
                                    <option value=""></option>
                                    <option value="Colec">TI</option>
                                    <option value="Medic">PE</option>
                                    <option value="Monog">IN</option>
                                </select>
                            </div>
                        </div>
                    </div>
                    <hr />
                    <div class="row">
                        <div class="col-xs-12 col-sm-4">
                            <label for="Signatura" class="sr-only">Signatura</label>
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-lock"></i>
                                <input type="text" name="_Signatura" id="Signatura" class="form-control input-theme" placeholder="Signatura">
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-4">
                            <label for="ISBN" class="sr-only">ISBN</label>
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-lock"></i>
                                <input type="text" name="_ISBN" id="ISBN" class="form-control input-theme" placeholder="Nº ISBN">
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-4">
                            <label for="OtroCodigo" class="sr-only">Otro Código</label>
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-lock"></i>
                                <input type="text" name="_OtroCodigo" id="OtroCodigo" class="form-control input-theme" placeholder="Otro Código">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="publicacion-footer-theme">
                <button class="btn btn-default">
                    <span class="glyphicon glyphicon-search"></span>
                    Buscar
                </button>
            </div>
        </div>
    End Using
    <div id="list-book">
        @If Not Model Is Nothing Then
            @For Each c In Model
                @<div class="panel panel-default">
                    <div class="panel-body">
                        <div class="input-group">
                            <span class="input-group-addon panel-compartido-img-theme">
                                <img class="compartido-img-theme" src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg" alt="" />
                            </span>
                            <div class="form-control compartido-theme">
                                <div class="dropdown pull-right">
                                    <button class="btn btn-default btn-xs dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                                        <span class="glyphicon glyphicon-option-vertical"></span> <span class="caret"></span>
                                    </button>
                                    <ul class="dropdown-menu" aria-labelledby="dropdownMenu1">
                                        <li><a href="#"><span class="glyphicon glyphicon-edit"></span>&nbsp;&nbsp;Eliminar</a></li>
                                        <li><a href="#"><span class="glyphicon glyphicon-trash"></span>&nbsp;&nbsp;Editar</a></li>
                                        <li role="separator" class="divider"></li>
                                        <li><a href="#"><span class="glyphicon glyphicon-eye-open"></span>&nbsp;&nbsp;Ver</a></li>
                                        <li><a href="#"><span class="glyphicon glyphicon-floppy-saved"></span>&nbsp;&nbsp;Guardar</a></li>
                                    </ul>
                                </div>
                                <a class="compartido-username-theme link-theme" href="#">
                                    <span class="glyphicon glyphicon-user icon-perfil"></span>
                                    <span class="icon-perfil">&nbsp;&nbsp;&nbsp;</span>
                                    Michel Roberto Traña Tablada
                                </a>
                                <br />
                                <span class="compartido-datetime-theme">
                                    <span class="glyphicon glyphicon-time"></span>
                                    &nbsp;&nbsp;&nbsp;
                                    31 de agosto del 2015 a las 13:26
                                    @c.FechaMod.Day de @c.ToString("MMMM") del @c.FechaMod.Year a las @c.FechaMod.ToString("HH:mm")
                                </span>
                            </div>
                        </div>
                        <hr />
                        <div class="">
                            <h2 class="titulo-book-theme">
                                <span class="pull-right glyphicon glyphicon-book"></span>
                                @c.TITULO
                            </h2>
                        </div>
                        <br />
                        <div class="book-info">
                            <div id="1" class="table-responsive more-book">
                                <table class="table table-striped table-book">
                                    <thead>
                                        <tr class="success">
                                            <td>ATRIBUTO</td>
                                            <td>CARACTERÍSTICAS</td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>Autor(es)</td>
                                            <td>
                                                @If c.AUTOR1 <> "" Then
                                                    @c.AUTOR1
                                                    @<span>,</span>
                                                End If
                                                @If c.AUTOR2 <> "" Then
                                                    @c.AUTOR2
                                                    @<span>,</span>
                                                End If
                                                @If c.AUTOR3 <> "" Then
                                                    @c.AUTOR3
                                                End If
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Publicado el</td>
                                            <td>@c.FECHAPUBLICACION</td>
                                        </tr>
                                        <tr>
                                            <td>Signatura</td>
                                            <td>@c.SIGNATURA</td>
                                        </tr>
                                        <tr>
                                            <td>Edición</td>
                                            <td>@c.EDICION</td>
                                        </tr>
                                    </tbody>
                                    @*<tfoot>
                                        <tr class="success">
                                            <td>ATRIBUTO</td>
                                            <td>CARACTERÍSTICAS</td>
                                        </tr>
                                    </tfoot>*@
                                </table>
                            </div>
                            <a href="#" class="btn btn-default btn-xs" role="button"><span class="glyphicon glyphicon-cloud"></span> Adjunto</a>
                            <a href="javascript:void(0);" data-id="1" class="btn btn-default btn-xs btn-more" role="button"><span class="glyphicon glyphicon-th-list"></span> <span class="text">Detalles</span></a>
                        </div>
                        <hr />
                        <div class="row">
                            <div class="col-xs-12">
                                <a href="#" class="favorite-public"><span class="glyphicon glyphicon-heart"></span></a>
                                <div class="favorite-text pull-right"><a href="#">1800 Favoritos</a></div>
                            </div>
                        </div>
                    </div>
                </div>
            Next
        Else
            @<div class="panel panel-default">
                <div class="panel-body">
                    <img class="img-responsive" src="~/Images/Busqueda.png" />
                </div>
            </div>
        End If
    </div>
</div>
@Section Scripts
    @Scripts.Render("~/bundles/selectbs")
    <script type="text/javascript">
        $(document).ready(function (e) {
            $('#tipodocumento').selectpicker();
            $('#tiporegistro').selectpicker();
            //boton ver mas
            //var btnmore = $(".btn-more");
            //$(btnmore).click(function (e) {
            //    var ID = $(this).data("id");
            //    $("#" + ID).toggle(
            //        "fast"
            //    );
            //    if (btnmore.children(".text").text() == "Detalles") {
            //        btnmore.children(".text").text("Ocultar");
            //    } else {
            //        btnmore.children(".text").text("Detalles");
            //    }
            //});
        });
    </script>
End Section
