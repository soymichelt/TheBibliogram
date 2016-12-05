@Code
    ViewData("Title") = "Bienvenido a la Biblioteca 'Alejandro Sequeira Hernández'"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<div class="col-sm-12 col-md-6">
    @Using Html.BeginForm(New With {.ReturnUrl = ViewData("ReturnUrl")})
        @Html.AntiForgeryToken()
        @Html.ValidationSummary(true)
        @<div class="publicacion-theme">
            <div class="panel-estado-heading-theme">
                <span class="text-left">
                    Publica lo que piensas
                </span>
                <span class="pull-right">
                    <span class="glyphicon glyphicon-edit  icon-perfil"></span>
                </span>
            </div>
            <div class="panel-estado-theme">
                <div class="">
                    <div class="input-group">
                        <span class="input-group-addon panel-img-estado-theme">
                            <img class="img-estado-theme" src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg" alt="" />
                        </span>
                        <textarea class="form-control input-estado-theme" rows="3" placeholder="Anda ¿Cuentanos lo qué está pasado?"></textarea>
                    </div>
                </div>
            </div>
            <div class="publicacion-footer-theme">
                <a class="btn btn-default" href="">
                    <span class="glyphicon glyphicon-camera"></span>
                </a>
                <span class="pull-right">
                    <button class="btn btn-default">
                        <span class="glyphicon glyphicon-cloud-upload"></span>
                        Publicar
                    </button>
                </span>
            </div>
        </div>
    End Using

    <div class="panel panel-default">
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
                    </span>
                    <hr class="hr-m1" />
                </div>
            </div>
            <div class="row">
                <div class="col-xs-12">
                    <div class="compartido-username-content-theme">
                        <h1>La Programación un mundo nuevo</h1>
                        <img class="img-responsive img img-public" src="~/Images/c5b598fd-fca7-44ca-9aac-3540d0df783e.jpeg" />
                    </div>
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-xs-12">
                    <a href="#" class="favorite-public"><span class="glyphicon glyphicon-heart"></span></a> <div class="favorite-text pull-right"><a href="#">1800 Favoritos</a></div>
                </div>
            </div>
        </div>
    </div>
    <div class="panel panel-default">
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
                    </span>
                    <hr />
                    <h1>La Programación un mundo nuevo</h1>
                    <img class="img-responsive img" src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg" />
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-xs-12">
                    <a href="#" class="favorite-public"><span class="glyphicon glyphicon-heart"></span></a>
                </div>
            </div>
        </div>
    </div>
    <div class="panel panel-default">
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
                    </span>
                    <hr />
                    <h1>La Programación un mundo nuevo</h1>
                    <img class="img-responsive img" src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg" />
                </div>
            </div>
            <hr />
            <div class="row">
                <div class="col-xs-12">
                    <a href="#" class="favorite-public"><span class="glyphicon glyphicon-heart"></span></a>
                </div>
            </div>
        </div>
    </div>
</div>