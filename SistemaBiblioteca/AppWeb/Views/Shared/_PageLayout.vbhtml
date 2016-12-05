@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
        <meta charset="utf-8" />
        <title>@ViewData("Title") - The Bibliogram</title>
        <link href="~/Images/Icono.ico" rel="shortcut icon" type="image/x-icon" />
        <meta name="viewport" content="width=device-width" />
        @Scripts.Render("~/bundles/modernizr")
        @RenderSection("styles", required:=False)
        @Styles.Render("~/Content/md")
    </head>
    <body>
        <!-- Dropdown Structure -->
        <ul id="dropdown1" class="dropdown-content">
          <li><a href="#!">one</a></li>
          <li><a href="#!">two</a></li>
          <li class="divider"></li>
          <li><a href="#!">three</a></li>
        </ul>
        <nav>
          <div class="nav-wrapper">
            <a href="#!" class="brand-logo">Logo</a>
              <a href="#" data-activates="mobile-demo" class="button-collapse"><i class="material-icons">menu</i></a>
            <ul class="right hide-on-med-and-down">
              <li><a href="sass.html">Sass</a></li>
              <li><a href="badges.html">Components</a></li>
              <!-- Dropdown Trigger -->
              <li><a class="dropdown-button" href="#!" data-activates="dropdown1">Dropdown<i class="material-icons right">arrow_drop_down</i></a></li>
            </ul>
          </div>
        </nav>

        <div class="body">
            @RenderBody()
        </div>

        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/md")
        @RenderSection("scripts", required:=False)
        <link href="http://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    </body>
</html>
