@Code
    ViewData("Title") = "Register"
    Layout = "~/Views/Shared/_AccountLayout.vbhtml"
End Code

<div id="Login">
    <img id="Logo" src="~/Images/Logo.png" class="img-responsive">
    
    <div class="form-signin">
        <h2 id="Titulo" class="text-center">¿Eres nuevo en <span class="the-bibliogram">The Bibliogram</span>? Regístrate.</h2>
        @Using Html.BeginForm(New With { .ReturnUrl = ViewData("ReturnUrl") })
            @Html.AntiForgeryToken()
            @Html.ValidationSummary(true)
            
            @<label for="Name" class="sr-only">Nombres</label>
            @<div id="c-Name" class="inner-addon left-addon">
                <i class="glyphicon glyphicon-asterisk"></i>
                <input type="text" name="Name" id="Name" class="form-control input-theme" placeholder="Nombres" required="required" autofocus="">
            </div>
            
            
            @<label for="LastName" class="sr-only">Apellidos</label>
            @<div  id="c-LastName" class="inner-addon left-addon">
                <i class="glyphicon glyphicon-asterisk"></i>
                <input type="text" name="Name" id="LastName" class="form-control input-theme" placeholder="Apellidos" required="required">
            </div>
            
            @<br />
            @<div class="dividerx20"></div>
            
            @<label for="Email" class="sr-only">Correo Electrónico</label>
            @<div id="c-Email" class="inner-addon left-addon">
                <i class="glyphicon glyphicon-user"></i>
                <input type="email" name="Email" id="Email" class="form-control input-theme" placeholder="Correo Electrónico" required="required">
            </div>
            
            @<br />
            
            @<label for="Password" class="sr-only">Contraseña</label>
            @<div class="inner-addon left-addon">
                <i class="glyphicon glyphicon-lock"></i>
                <input type="password" name="Password" id="Password" class="form-control input-theme" placeholder="Contraseña" required="required">
            </div>
            
            @<br />
            
            @<button id="BtnSesion" class="btn btn-lg btn-success btn-block btn-theme" type="submit">Registrarte</button>
            @<br />
            @<div class="text-center">
                <a class="text-center" href="#">Iniciar Sesión</a>
            </div>
        End Using
    </div>

</div>