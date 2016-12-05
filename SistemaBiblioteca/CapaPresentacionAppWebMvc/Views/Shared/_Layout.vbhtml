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
        <link href="~/Content/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
        @Styles.Render("~/Content/css")
        @Styles.Render("~/Content/general")
    </head>
    <body>
        @Html.Partial("_Header")
        <div class="container body">
            @RenderBody()
        </div>
        @Html.Partial("_Footer")


        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/bootstrap")
        @RenderSection("scripts", required:=False)
    </body>
</html>
