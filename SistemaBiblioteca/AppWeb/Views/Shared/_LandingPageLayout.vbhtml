@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
<html lang="es">
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <meta charset="utf-8" />
        <title>@ViewData("Title") - The Bibliogram</title>
        <link href="~/Images/Icono.ico" rel="shortcut icon" type="image/x-icon" />
        <meta name="viewport" content="width=device-width" />
        @Scripts.Render("~/bundles/modernizr")
        @RenderSection("styles", required:=False)
        @Styles.Render("~/Content/general")
        @Styles.Render("~/Content/css")
        @Styles.Render("~/Content/landingpage")
    </head>
    <body>
        @Html.Partial("_Header")
        <div class="body">
            @RenderBody()
        </div>
        @Html.Partial("_Footer")
        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)
    </body>
</html>