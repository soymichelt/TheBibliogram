@Code
    Layout = "~/Views/Shared/_AccountLayout.vbhtml"
End Code

<div id="Login">
    <img id="Logo" src="~/Images/Logo.png" class="img-responsive">
    
    <div class="form-signin">
        <h2 id="Titulo" class="text-center">Iniciar sesión con tu cuenta.</h2>
        @Using Html.BeginForm(New With { .ReturnUrl = ViewData("ReturnUrl") })
            @Html.AntiForgeryToken()
            @Html.ValidationSummary(true)
            
            @<label for="inputEmail" class="sr-only">Correo Electrónico</label>
            @<div class="inner-addon left-addon">
                <i class="glyphicon glyphicon-user"></i>
                <input type="email" name="inputEmail" id="inputEmail" class="form-control" placeholder="Correo Electrónico" required="required" autofocus="">
            </div>
            @<br />
            @<label for="inputPassword" class="sr-only">Contraseña</label>
            @<div class="inner-addon left-addon">
                <i class="glyphicon glyphicon-lock"></i>
                <input type="password" name="inputPassword" id="inputPassword" class="form-control" placeholder="Contraseña" required="required">
            </div>
            @<br />
            @<button id="BtnSesion" class="btn btn-lg btn-success btn-block" type="submit">Iniciar Sesión</button>
            @<br />
            @<div class="text-center">
                <a class="text-center" href="#">¿Haz olvidado tu contraseña?</a>
            </div>
        End Using
    </div>

</div>