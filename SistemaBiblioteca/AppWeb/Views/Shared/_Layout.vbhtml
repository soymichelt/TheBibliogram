@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
<html lang="es">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta charset="utf-8" />
        <title>@ViewData("Title") - The Bibliogram</title>
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
        <meta name="viewport" content="width=device-width" />
        @Scripts.Render("~/bundles/modernizr")
        @Styles.Render("~/Content/general")
        @Styles.Render("~/Content/css")
    </head>
    <body>
        @Html.Partial("_Header")
        <div class="container-fluid body">
            <div class="col-sm-12 col-md-3">
                <div class="panel panel-success panel-theme">
                    <div class="panel-heading perfil-photo">
                        <div class="row">
                            <div class="perfil-user">
                                <a href="#">
                                    <img class="img-perfil" src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg" />
                                </a>
                            </div>
                        </div>
                    </div>
                    <div class="dividerx20"></div>
                    <div class="panel-body">
                        <div class="info-perfil">
                            <a class="name" href="#">
                                <span class="glyphicon glyphicon-user icon-perfil"></span>&nbsp;&nbsp;&nbsp;&nbsp;Michel Roberto Traña Tablada
                            </a>
                            <br />
                            <a class="link-theme" href="#">
                                <span class="glyphicon glyphicon-envelope icon-perfil"></span>&nbsp;&nbsp;&nbsp;mtraatabladaa94@gmail.com
                            </a>
                            <br />
                            <a class="link-theme" href="#">
                                <span class="glyphicon glyphicon-time"></span>&nbsp;&nbsp;&nbsp;Nació el 2 de septiembre de 1994
                            </a>
                        </div>
                    </div>
                </div>
                <div class="list-group">
                    <div class="list-group-item list-group-item-success">
                        <span class="glyphicon glyphicon-star icon-perfil"></span>&nbsp;&nbsp;&nbsp;Favoritos
                    </div>
                    <a href="#" class="list-group-item link-theme">
                        <span class="glyphicon glyphicon-briefcase icon-perfil"></span>&nbsp;&nbsp;&nbsp;Recomendados
                    </a>
                    <a href="#" class="list-group-item link-theme">
                        <span class="glyphicon glyphicon-share icon-perfil"></span>&nbsp;&nbsp;&nbsp;Publicaciones
                    </a>
                    <a href="#" class="list-group-item link-theme">
                        <span class="glyphicon glyphicon-thumbs-up icon-perfil"></span>&nbsp;&nbsp;&nbsp;Genial
                    </a>
                </div>
                <div class="panel panel-success">
                    <div class="panel-heading">
                        <span class="glyphicon glyphicon-list-alt icon-perfil"></span>&nbsp;&nbsp;&nbsp;Guardados
                    </div>
                    <div class="panel-body text-theme">
                        © SGBU 2015 - <a class="link-theme" href="#">UNAN FAREM Chontales</a>.
                        <hr />
                        Desarrollado por: <a class="link-theme" href="#">Elizabeth del Socorro Silva Urbina</a> y <a class="link-theme" href="#">Michel Roberto Traña Tablada</a>
                    </div>
                </div>
            </div>
            @RenderBody()
            <div class="col-sm-12 col-md-3">
                <div class="panel panel-success panel-theme">
                    <div class="panel-heading">
                        <span class="glyphicon glyphicon-star icon-perfil"></span>&nbsp;&nbsp;&nbsp;Los 10 mas buscados
                    </div>
                    <div class="panel-body">
                        
                    </div>
                </div>
                <div class="panel panel-success panel-theme">
                    <div class="panel-heading">
                        <span class="glyphicon glyphicon-share icon-perfil"></span>&nbsp;&nbsp;&nbsp;Publicaciones Recientes
                    </div>
                    <div class="panel-body">
                        
                    </div>
                </div>
                <div class="panel panel-default">
                    <div class="panel-body text-theme">
                        © SGBU 2015 - <a class="link-theme" href="#">UNAN FAREM Chontales</a>.
                        <hr />
                        Desarrollado por: <a class="link-theme" href="#">Elizabeth del Socorro Silva Urbina</a> y <a class="link-theme" href="#">Michel Roberto Traña Tablada</a>
                    </div>
                </div>
            </div>
        </div>
        @*@Html.Partial("_Footer")*@


        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)
    </body>
</html>
