@ModelType AppWeb.RecomendacionServicio.DRecomendacion

@Code
    ViewData("Title") = "Recomendar"
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
            @Using Html.BeginForm("Recomendar", "Home", New With {.ReturnUrl = ViewData("ReturnUrl")}, FormMethod.Post, New With {.Id = "_RecomendarBibliografia"})
                @<div>
                    <div class="input-group">
                        <span class="input-group-addon f12">Dirigido a</span>
                        @Html.DropDownListFor(Function(f) f.AreaDirigida, New SelectList(New List(Of listitem) from {New listitem With {.Value = "Ciencias Economicas y Administrativas", .Text = "Ciencias Economicas y Administrativas"}, New ListItem With {.Value = "Ciencia, Tecnología y Salud", .Text = "Ciencia, Tecnología y Salud"}, New ListItem With {.Value = "Ciencias de la Educación y Humanidades", .Text = "Ciencias de la Educación y Humanidades"}}), New With {.class = "form-control input-theme select", .required="required", .autofocus=""})
                    </div>
                    <div class="dividerx10"></div>
                    <div class="inner-addon left-addon">
                        <i class="glyphicon glyphicon-file"></i>
                        @Html.TextBoxFor(Function(f) f.Titulo, New With {.class="form-control input-theme", .placeholder="Título de la Bibliografía", .required="required"})
                    </div>
                    <div class="dividerx10"></div>
                    <div class="inner-addon left-addon">
                        <i class="glyphicon glyphicon-file"></i>
                        @Html.TextBoxFor(Function(f) f.OtroTitulo, New With {.class="form-control input-theme", .placeholder="Otro título"})
                    </div>
                    <div class="dividerx10"></div>
                    <div class="inner-addon left-addon">
                        <i class="glyphicon glyphicon-user"></i>
                        @Html.TextBoxFor(Function(f) f.Autores, New With {.class="form-control input-theme", .placeholder="Autor(es) / Institución", .required="required"})
                    </div>
                    <div class="dividerx10"></div>
                    <div class="row">
                        <div class="col-xs-12 col-sm-4">
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-lock"></i>
                                @Html.TextBoxFor(Function(f) f.Isbn, New With {.class="form-control input-theme", .placeholder="Nº ISBN"})
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-4">
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-lock"></i>
                                @Html.TextBoxFor(Function(f) f.Volumen, New With {.class = "form-control input-theme", .placeholder = "Volumen"})
                            </div>
                        </div>
                        <div class="col-xs-12 col-sm-4">
                            <div class="inner-addon left-addon">
                                <i class="glyphicon glyphicon-lock"></i>
                                @Html.TextBoxFor(Function(f) f.Edicion, New With {.class="form-control input-theme", .placeholder="Edición"})
                            </div>
                        </div>
                    </div>
                    <div class="dividerx10"></div>
                    <h5>Nota / Descripción / Observación</h5>
                    <div class="dividerx10"></div>
                    <div class="inner-addon left-addon">
                        <i class="glyphicon glyphicon-info-sign"></i>
                        @Html.TextAreaFor(Function(f) f.Nota, New With {.class = "form-control input-theme", .placeholder = "Nota, Descripción, Observación", .required = "required", .rows="4"})
                    </div>
                </div>
                @<br />
                @<button class="btn btn-default btn-sm" type="submit">
                    <span class="glyphicon glyphicon-share"></span>
                    Publicar
                </button>
            End Using
        </div>
        @*@If Not ViewBag("Title") Is Nothing Then
            @<div class="alert alert-warning alert-dismissible" role="alert">
                <button type="button" class="close" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                <strong>Advertencia!</strong> @ViewBag("infomessage")
            </div>
        End If*@
    </div>
</div>
@Section ScriptsPage
    <script type="text/javascript">
        $(document).ready(function () {
            $("#_RecomendarBibliografia").removeattr("novalidate");
        });
    </script>
End Section