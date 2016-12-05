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
<nav class="navbar navbar-default">
    <div class="container">
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
            <div class="navbar-form navbar-right" role="search">
                <a href="@Url.Action("Register", "AccountAdmin", Nothing)" class="btn btn-warning btn-register"><span class="glyphicon glyphicon-grain"></span> Regístrate</a>
                <a href="@Url.Action("Signin", "AccountAdmin", Nothing)" class="btn btn-success btn-login"><span class="glyphicon glyphicon-user"></span> Iniciar Sesión</a>
            </div>
        </div>
        <!-- /.navbar-collapse -->
    </div>
    <!-- /.container-fluid -->
</nav>