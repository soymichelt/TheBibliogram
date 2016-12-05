@Code
    Layout = "~/Views/Shared/_AccountLayout.vbhtml"
    ViewData("Title") = "Iniciar Sesión"
End Code
@If Not ViewData("Mensaje") Is Nothing Then
    @<div class="alert alert-danger" role="alert">
        @ViewData("Mensaje")
        <a href="#" class="alert-link">Inicio</a>
    </div>
End If
<div id="Login">
    <img id="Logo" src="~/Images/Logo.png" class="img-responsive">
    <div class="form-signin">
        <h2 id="Titulo" class="text-center">Iniciar sesión con tu cuenta.</h2>
        @Using Html.BeginForm(New With {.ReturnUrl = ViewData("ReturnUrl")})
            @Html.AntiForgeryToken()
            @Html.ValidationSummary(true)
            
            @<label for="inputEmail" class="sr-only">Correo Electrónico</label>
            @<div class="inner-addon left-addon">
                <i class="glyphicon glyphicon-user"></i>
                <input type="email" name="Usuario" id="inputEmail" class="form-control input-theme" placeholder="Correo Electrónico" required="required" autofocus="">
            </div>
            @<br />
            @<label for="inputPassword" class="sr-only">Contraseña</label>
            @<div class="inner-addon left-addon">
                <i class="glyphicon glyphicon-lock"></i>
                <input type="password" name="Password" id="inputPassword" class="form-control input-theme" placeholder="Contraseña" required="required">
            </div>
            @<br />
            @<button id="BtnSesion" class="btn btn-lg btn-success btn-block btn-theme" type="submit">Iniciar Sesión</button>
            @<br />
            @<div class="text-center">
                <a class="text-center" href="#">¿Haz olvidado tu contraseña?</a>
            </div>
        End Using
    </div>
</div>