@* MENU 1 *@
@*<div class="navs-sigin">
    <div class="container header">
        <div class="row">
            <div class="col-sm-3 col-md-6">
                <a href="/">
                    <img id="logo-menu" src="~/Images/LogoMenu.png" />
                </a>
            </div>
            <div class="col-xs-12 dividerx20 visible-xs"></div>
            <div class="col-xs-12 col-sm-3 col-md-2">
                <div class="btn-group btn-block">
                    <button type="button" class="btn btn-primary btn-block btn-menu dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        <span class="glyphicon glyphicon-info-sign"></span>
                        Información 
                                <span class="caret"></span>
                    </button>
                    <ul class="dropdown-menu">
                        <li><a href="#"><span class="glyphicon glyphicon-home"></span>&nbsp;-&nbsp; Biblioteca</a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-envelope"></span>&nbsp;-&nbsp; Contacto</a></li>
                        <li><a href="#"><span class="glyphicon glyphicon-list-alt"></span>&nbsp;-&nbsp; Blog de Noticias</a></li>
                    </ul>
                </div>
            </div>
            <div class="col-xs-12 dividerx10 visible-xs"></div>
            <div class="col-xs-12 col-sm-3 col-md-2">
                <button class="btn btn-success btn-block btn-login">
                    <span class="glyphicon glyphicon-user"></span>
                    <span class="visible-md visble-lg">&nbsp;&nbsp;</span>
                    Iniciar Sesión
                </button>
            </div>
            <div class="col-xs-12 dividerx10 visible-xs"></div>
            <div class="col-xs-12 col-sm-3 col-md-2">
                <button class="btn btn-warning btn-block btn-register">
                    <span class="glyphicon glyphicon-grain"></span>
                    <span class="visible-md visble-lg">&nbsp;&nbsp;</span>
                    Registrarse
                </button>
            </div>
        </div>
    </div>
</div>*@





@* MENU 2 *@
<nav class="navbar navbar-default navbar-fixed-top">
    <div class="container-fluid">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
            <a class="navbar-brand" href="/">
                <img id="logo-menu" src="~/Images/LogoMenu.png" />
            </a>
        </div>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            @If Not Session("_AuthenticationState") Is Nothing Then
                If Session("_AuthenticationState").ToString() = "1" Then
                    @<ul class="nav navbar-nav navbar-right">
                        @If Not Session("Rol") Is Nothing Then
                            If Session("Rol") = "1" Or Session("Rol") = "5" or Session("Rol") = "6" Then
                                @<li>
                                    <a href="@Url.Action("Index", "Administrator")" class="link-menu ic32">
                                        <span class="glyphicon glyphicon-dashboard"></span>
                                    </a>
                                 </li>
                            End If
                        End If
                        <li class="dropdown">
                            <a href="#" class="link-menu ic32" title="Menú de The Bibliogram" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
                                <span class="glyphicon glyphicon-th"></span>
                            </a>
                            <ul class="dropdown-menu">
                                <li><a href="#"><span class="glyphicon glyphicon-home"></span> Inicio</a></li>
                                <li role="separator" class="divider"></li>
                                <li><a href="#"><span class="glyphicon glyphicon-book"></span> Biblioteca</a></li>
                                <li role="separator" class="divider"></li>
                                <li><a href="@Url.Action("Recomendar", "Home")"><span class="glyphicon glyphicon-share"></span> Recormendar</a></li>
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a class="link-profile" href="#"data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
                                <span class="text">@Session("Name")</span>
                                <img class="img-profile-menu" src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg" />
                            </a>
                            <ul class="dropdown-menu">
                                <li>
                                    <div class="section-profile-menu list-group">
                                        <a href="#" class="list-group-item">
                                            <span class="list-group-item-heading">@Session("Name")</span>
                                            <br />
                                            <span class="list-group-item-text">Ver Perfil</span>
                                        </a>
                                    </div>
                                </li>
                                <li><a href="#">Cambiar Contraseña</a></li>
                                <li role="separator" class="divider"></li>
                                <li><a href="#">Búsquedas Realizadas</a></li>
                                <li><a href="#">Recomendaciones</a></li>
                                <li><a href="#">Favoritos</a></li>
                                <li><a href="#">Guardados</a></li>
                                <li role="separator" class="divider"></li>
                                <li><a href="@Url.Action("Signout","AccountSecurity")">Cerrar Sesión</a></li>
                            </ul>
                        </li>
                    </ul>
                Else
                    @<div class="navbar-form navbar-right" role="search">
                        <a href="@Url.Action("Register", "AccountSecurity", Nothing)" class="btn btn-primary btn-register"><span class="glyphicon glyphicon-grain"></span> Regístrate</a>
                        <a href="@Url.Action("Signin", "AccountSecurity", Nothing)" class="btn btn-success btn-login"><span class="glyphicon glyphicon-user"></span> Iniciar Sesión</a>
                    </div>
                End If
            Else
                @<div class="navbar-form navbar-right" role="search">
                    <a href="@Url.Action("Register", "AccountSecurity", Nothing)" class="btn btn-primary btn-register"><span class="glyphicon glyphicon-grain"></span> Regístrate</a>
                    <a href="@Url.Action("Signin", "AccountSecurity", Nothing)" class="btn btn-success btn-login"><span class="glyphicon glyphicon-user"></span> Iniciar Sesión</a>
                </div>
            End If
        </div>
        <!-- /.navbar-collapse -->
    </div>
    <!-- /.container-fluid -->
</nav>