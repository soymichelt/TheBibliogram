@ModelType List(Of AppWeb.LibroServicio.DLibro)

@Code
    ViewData("Title") = "Búsqueda de Bibliografía en la Biblioteca 'Alejandro Sequeira Hernández'"
    Layout = "~/Views/Shared/_UsersLandingPageLayout.vbhtml"
End Code
@Styles.Render("~/Content/search")

@* resultados de la busqueda *@
<div class="col-md-8">
    <div class="panel panel-default panel-theme">
        <div class="panel-body">
            <div class="media media-theme">
                <div class="media-body media-middle">
                    <h5><span class="glyphicon glyphicon-briefcase"></span> <a class="link-parr-theme" href="#">Hey Michel</a>, Utiliza nuestra Búsqueda Online</h5>
                </div>
                <div class="media-right">
                    <a href="#">
                        <img class="circle media-object" src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg" />
                    </a>
                </div>
            </div>
            <hr />
            <div class="dividerx10"></div>
            @Using Html.BeginForm("SearchBooksLibrary", "Home", New With {.ReturnUrl = ViewData("ReturnUrl")}, FormMethod.Get)
                @<div class="input-group">
                    <div class="inner-addon left-addon">
                        <i class="glyphicon glyphicon-file"></i>
                        <input type="text" name="_Titulo" id="Titulo" class="form-control input-theme" placeholder="Título del fondo bibliográfico" autofocus="">
                    </div>
                    <span class="input-group-btn">
                        <button id="_btn-search-advanced" class="btn btn-default" type="button">
                            <span class="caret"></span>
                        </button>
                    </span>
                </div>
                @<div id="_search-advanced" style="display:none;">
                    <div class="dividerx10"></div>
                    <div class="row">
                        <div class="col-xs-12 col-sm-6">
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-user"></i>
                                <input type="text" name="_Autor" id="Autor" class="form-control input-theme" placeholder="Autor personal">
                            </div>
                        </div>
                        <div class="dividerx10 visible-xs"></div>
                        <div class="col-xs-12 col-sm-6">
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-user"></i>
                                <input type="text" name="_Institucion" id="Institucion" class="form-control input-theme" placeholder="Institución">
                            </div>
                        </div>
                    </div>
                    <div class="dividerx10"></div>
                    <div class="row">
                        <div class="col-xs-12 col-sm-6">
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
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-lock"></i>
                                <input type="text" name="_Signatura" id="Signatura" class="form-control input-theme" placeholder="Signatura">
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-4">
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-lock"></i>
                                <input type="text" name="_ISBN" id="ISBN" class="form-control input-theme" placeholder="Nº ISBN">
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-4">
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-lock"></i>
                                <input type="text" name="_OtroCodigo" id="OtroCodigo" class="form-control input-theme" placeholder="Otro Código">
                            </div>
                        </div>
                    </div>
                </div>
                @<br />
                @<button class="btn btn-default btn-sm" type="submit">
                    <span class="glyphicon glyphicon-search"></span>
                    Buscar
                    </button>
            End Using
        </div>
    </div>
    <div class="_DataResult">
        <div class="row">
            <div class="col-xs-12">
                @If Not Model Is Nothing Then
                    @For Each c In Model
                        @<div class="r-search">
                            <div class="books">
                                <div class="media">
                                    <div class="media-left">
                                        <a href="#">
                                            <img class="img-profile-result" src="~/Images/12072657_544882125664486_9053319431430923796_n.jpg" />
                                        </a>
                                    </div>
                                    <div class="media-body name-profile-result">
                                        <div class="dropdown pull-right">
                                            <button class="btn btn-default btn-xs dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                                                <span class="glyphicon glyphicon-option-vertical"></span>
                                            </button>
                                            <ul class="dropdown-menu" aria-labelledby="dropdownMenu1">
                                                <li><a href="#"><span class="glyphicon glyphicon-edit"></span>&nbsp;&nbsp;Eliminar</a></li>
                                                <li><a href="#"><span class="glyphicon glyphicon-trash"></span>&nbsp;&nbsp;Editar</a></li>
                                                <li role="separator" class="divider"></li>
                                                <li><a href="#"><span class="glyphicon glyphicon-eye-open"></span>&nbsp;&nbsp;Ver</a></li>
                                                <li><a href="#"><span class="glyphicon glyphicon-floppy-saved"></span>&nbsp;&nbsp;Guardar</a></li>
                                            </ul>
                                        </div>
                                        <h4 class="media-heading profile-name-result">
                                            <a href="#">
                                                Michel Roberto Traña Tablada
                                            </a>
                                        </h4>
                                        <div class="profile-info-result">
                                            <a href="#">
                                                <span class="glyphicon glyphicon-globe"></span> @c.FechaMod.ToString("dd") de @c.FechaMod.ToString("MMMM") del @c.FechaMod.Year a las @c.FechaMod.ToString("HH:mm")
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <br />
                                <div class="row">
                                    <div class="band-theme">
                                        <div class="col-xs-3 b">
                                        </div>
                                        <div class="col-xs-3 r">
                                        </div>
                                        <div class="col-xs-3 y">
                                        </div>
                                        <div class="col-xs-3 g">
                                        </div>
                                    </div>
                                </div>
                                <br />
                                <div class="info-book">
                                    @*<a href="#">
                                        <img class="img-result img-responsive" src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg" />
                                    </a>*@
                                    <h4 class="info">
                                        <a href="#">
                                            @c.TITULO <span class="SubTitle">&nbsp;@c.OTRO_TITULO</span>
                                        </a>
                                    </h4>
                                    Nº <span class="attrib">@c.SIGNATURA</span>
                                    •
                                    Por <span class="attrib">
                                            @If c.AUTOR1.Trim() <> "" Then
                                                @c.AUTOR1
                                            End If
                                            @If c.AUTOR2.Trim() <> "" Then
                                                @<span>,&nbsp;</span>
                                                @c.AUTOR2
                                            End If
                                            @If c.AUTOR3.Trim() <> "" Then
                                                @<span>,&nbsp;</span>
                                                @c.AUTOR3
                                            End If
                                        </span>
                                    •
                                    En <span class="attrib">@c.IDIOMA</span>
                                    •
                                    Edición <span class="attrib">@c.EDICION</span>
                                    •
                                    De <span class="attrib">@c.EDITORA</span>
                                    •
                                    Cita Bibliográfica
                                    <span class="attrib">(@c.Norma, @c.Estilo)</span>
                                    <span class="attrib cita"><span class="com-open">“</span>@c.Cita<span class="com-close">”</span></span>
                                </div>
                                <div class="row footer-result">
                                    <hr />
                                    <div class="col-xs-3">
                                        <a class="Fav" href="#"><span class="glyphicon glyphicon-heart"></span></a>
                                    </div>
                                    <div class="col-xs-9">
                                        <span class="pull-right Fav-Cont">
                                            <a href="#">1, 498, 65</a>
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    Next
                End If
            </div>
        </div>
    </div>
</div>
@Section ScriptsPage
    <script type="text/javascript">
        $(document).ready(function () {
            $("#_btn-search-advanced").click(function () {
                $("#_search-advanced").toggle();
            });
        });
    </script>
End Section