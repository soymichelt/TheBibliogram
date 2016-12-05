@Code
    Layout = "~/Views/Shared/_LandingPageLayout.vbhtml"
End Code

<div class="body">
    <div class="container-fluid">
        <div class="row">
            <div class="col-sm-12 col-md-4">
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
                <div class="list-group list-theme">
                    <div class="list-group-item list-group-item-success list-heading">
                        <span class="glyphicon glyphicon-star icon-perfil"></span>&nbsp;&nbsp;&nbsp;Favoritos
                    </div>
                    <a href="@Url.Action("Search", "Home")" class="list-group-item link-theme">
                        <span class="glyphicon glyphicon-search icon-perfil"></span>&nbsp;&nbsp;&nbsp;Búsquedas Realizadas
                    </a>
                    <a href="@Url.Action("Recomendaciones", "Home")" class="list-group-item link-theme">
                        <span class="glyphicon glyphicon-briefcase icon-perfil"></span>&nbsp;&nbsp;&nbsp;Recomendaciones
                    </a>
                    <a href="@Url.Action("Fav", "Home")" class="list-group-item link-theme">
                        <span class="glyphicon glyphicon-thumbs-up icon-perfil"></span>&nbsp;&nbsp;&nbsp;Favoritos
                    </a>
                    <a href="@Url.Action("Saved", "Home")" class="list-group-item link-theme">
                        <span class="glyphicon glyphicon-bookmark icon-perfil"></span>&nbsp;&nbsp;&nbsp;Guardados
                    </a>
                    <a href="@Url.Action("Books", "Home")" class="list-group-item link-theme">
                        <span class="glyphicon glyphicon-book icon-perfil"></span>&nbsp;&nbsp;&nbsp;Libros Consultados
                    </a>
                </div>
                <div class="list-group list-theme">
                    <div class="list-group-item list-group-item-success list-heading">
                        <span class="glyphicon glyphicon-dashboard icon-perfil"></span>&nbsp;&nbsp;&nbsp;Actividades
                    </div>
                    <a href="@Url.Action("Search", "Home")" class="list-group-item link-theme">
                        <span class="glyphicon glyphicon-level-up icon-perfil"></span>&nbsp;&nbsp;&nbsp;Solicitudes
                    </a>
                    <a href="@Url.Action("Recomendaciones", "Home")" class="list-group-item link-theme">
                        <span class="glyphicon glyphicon-list-alt icon-perfil"></span>&nbsp;&nbsp;&nbsp;Préstamos y Entregas
                    </a>
                    <a href="@Url.Action("Fav", "Home")" class="list-group-item link-theme">
                        <span class="glyphicon glyphicon-folder-close icon-perfil"></span>&nbsp;&nbsp;&nbsp;Solvencia
                    </a>
                </div>
                <div class="panel panel-default panel-theme">
                    <div class="panel-body text-theme">
                        <div class="media media-theme">
                            <div class="media-left">
                                <a href="http://www.chontales.unan.edu.ni" target="_blank">
                                    <img src="~/Images/LogoUNAN.png" alt="UNAN FAREM - Chontales" class="media-object" />
                                </a>
                            </div>
                            <div class="media-body">
                                <a class="link-theme" href="#">© @DateTime.Now.Year SGBD - UNAN FAREM Chontales</a>
                            </div>
                        </div>
                        <hr />
                        <h5 class="black">Desarrollado por:</h5>
                        <div class="media media-theme">
                            <div class="media-left">
                                <a href="http://www.chontales.unan.edu.ni" target="_blank">
                                    <img src="~/Images/20140910_132322_.jpg" alt="Elizabeth del Socorro Silva Urbina" class="circle media-object" />
                                </a>
                            </div>
                            <div class="media-body">
                                <a class="link-theme" href="#">Ing. Elizabeth del Socorro Silva Urbina</a>
                            </div>
                        </div>
                        <div class="media media-theme">
                            <div class="media-left">
                                <a href="http://www.chontales.unan.edu.ni" target="_blank">
                                    <img src="~/Images/12072657_544882125664486_9053319431430923796_n.jpg" alt="Michel Roberto Traña Tablada" class="circle media-object" />
                                </a>
                            </div>
                            <div class="media-body">
                                <a class="link-theme" href="#"> Ing. Michel RobertoTraña Tablada</a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            @RenderBody()
        </div>
    </div>
</div>
@Section scripts
    @RenderSection("ScriptsPage", required:=False)
End Section