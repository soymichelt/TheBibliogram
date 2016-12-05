@ModelType List(Of AppWeb.RecomendacionServicio.DRecomendacion)

@Code
    ViewData("Title") = "Recomendaciones"
    Layout = "~/Views/Shared/_UsersLandingPageLayout.vbhtml"
End Code

@Styles.Render("~/Content/search")

<div class="col-md-8">
    <div class="panel panel-default panel-theme">
        <div class="panel-body">
            <div class="media media-theme">
                <div class="media-body media-middle">
                    <h5><span class="glyphicon glyphicon-briefcase"></span> <a class="link-parr-theme" href="#">Oye Michel</a>, Recomiendanos alguna bibliografía</h5>
                </div>
                <div class="media-right">
                    <a href="#">
                        <img class="circle media-object" src="~/Images/12003204_541728029313229_5836465946492033943_n.jpg" />
                    </a>
                </div>
            </div>
            <hr />
            @Using Html.BeginForm("Recomendaciones", "Home", New With {.ReturnUrl = ViewData("ReturnUrl")}, FormMethod.Post, New With {.Id = "_Busqueda"})
                @<div>
                    <div class="row">
                        <div class="col-xs-12 col-sm-6">
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-calendar"></i>
                                <input name="Inicio" type="date" class="form-control input-theme" placeholder="Fecha Inicial" />
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-6">
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-calendar"></i>
                                <input name="Fin" type="date" class="form-control input-theme" placeholder="Fecha Final" />
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
    <div class="panel panel-default panel-theme">
        <div class="panel-body">
            <div class="">

            </div>
            @For Each c In Model
                
            Next
        </div>
    </div>
</div>
@Section ScriptsPage
    <script type="text/javascript">
        $(document).ready(function () {
            $("#_Busqueda").removeattr("novalidate");
        });
    </script>
End Section