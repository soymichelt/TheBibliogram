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
        @Styles.Render("~/Content/general")
        @Styles.Render("~/Content/account")
        @Styles.Render("~/Content/css")
    </head>
    <body>
        @Html.Partial("_Header")
        <div class="container body">
            <div class="row">
                @RenderBody()
            </div>
        </div>
        @Html.Partial("_Footer")

        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)
    </body>
</html>
